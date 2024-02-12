using StudentSorter.Gambling.Cards;
using System.Data;
using StudentSorter.Debug;
using StudentSorter.CardGames.Poker.Player;
using StudentSorter.CardGames.Cards;
using StudentSorter.CardGames.Poker.Holdem;

namespace StudentSorter.CardGames.Poker.Forms
{
    public partial class FinalRoundWindow : Form
    {
        public HoldemManager Manager { get; set; }

        public DataTable PlayerCardTable = new();
        public DataTable CommunityCardTable = new();
        public DataTable BestHandTable = new();

        public List<Card> BestPlayerHand = new();

        public FinalRoundWindow(HoldemManager manager)
        {
            InitializeComponent();
            Manager = manager;

            PlayerCardList.DataSource = PlayerCardTable;
            CommunityCardList.DataSource = CommunityCardTable;
            BestHandList.DataSource = BestHandTable;

            PlayerCardTable.Columns.Add("Card", typeof(string));
            CommunityCardTable.Columns.Add("Card", typeof(string));
            BestHandTable.Columns.Add("Card", typeof(string));

            UpdateTables();
        }

        /// <summary>
        /// Adds player and community cards
        /// to their tables. Updates player's best
        /// hand table
        /// </summary>
        public void UpdateTables()
        {
            BestPlayerHand.Sort(new CardComparer());

            if (PlayerCardTable.Rows.Count > 0) PlayerCardTable.Rows.Clear();
            if (CommunityCardTable.Rows.Count > 0) CommunityCardTable.Rows.Clear();
            if (BestHandTable.Rows.Count > 0) BestHandTable.Rows.Clear();

            foreach (Card card in Manager.Players[0].PlayerHand.Cards)
                PlayerCardTable.Rows.Add(card);

            foreach (Card card in Manager.CommunityCards)
                CommunityCardTable.Rows.Add(card);

            foreach (Card card in BestPlayerHand)
                BestHandTable.Rows.Add(card);

            foreach (DataGridViewColumn col in PlayerCardList.Columns) col.Width = PlayerCardList.Width;
            foreach (DataGridViewColumn col in CommunityCardList.Columns) col.Width = CommunityCardList.Width;
            foreach (DataGridViewColumn col in BestHandList.Columns) col.Width = BestHandList.Width;

            if (BestPlayerHand.Count == 5)
                EndRoundButton.Enabled = true;

            Debugger.Log("Updated card tables");
        }

        /// <summary>
        /// Adds a card to the player's best hand
        /// from the player's own hole cards
        /// </summary>
        private void PlayerCardList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BestPlayerHand.Count >= 5) return;

            int index = PlayerCardList.CurrentCell.RowIndex;
            Card card = Manager.Players[0].PlayerHand.Cards[index];

            if (!BestPlayerHand.Contains(card))
                BestPlayerHand.Add(card);

            Debugger.Log($"Added {card} to Player's hand");
            UpdateTables();
        }

        /// <summary>
        /// Adds a card to the player's best hand
        /// from the community cards
        /// </summary>
        private void CommunityCardList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (BestPlayerHand.Count >= 5) return;

            int index = CommunityCardList.CurrentCell.RowIndex;
            Card card = Manager.CommunityCards[index];

            if (!BestPlayerHand.Contains(card))
                BestPlayerHand.Add(card);

            Debugger.Log($"Added {card} to Player's hand");
            UpdateTables();
        }

        /// <summary>
        /// Removes a card from best
        /// player hand
        /// </summary>
        private void BestHandList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Card card = BestPlayerHand[Card.FindCardInList(BestHandList.CurrentCell.Value.ToString(), BestPlayerHand)];

                BestPlayerHand.Remove(card);
                EndRoundButton.Enabled = false;

                try { Debugger.Log($"Removed {card} from Player's hand"); }
                catch (Exception) { Debugger.Log("Player best hand is probably empty."); }
            }
            catch(Exception)
            {
                Debugger.Log("Error in removing the card");
            }

            UpdateTables();
        }

        /// <summary>
        /// Goes to final winner declaration window
        /// </summary>
        private void EndRoundButton_Click(object sender, EventArgs e)
        {
            Close();
            Manager.Players[0].PlayerHand.Cards.Clear();

            foreach (Card card in BestPlayerHand)
                Manager.Players[0].PlayerHand.AddCard(card);

            // All bots pick their 5 best cards
            foreach (PokerPlayer player in Manager.Players)
            {
                if (player.Folded || player.Name.Equals("Player")) continue;

                PickBestHand(player);
            }

            WinnerWindow winnerWindow = new(Manager);
            winnerWindow.Show();
        }

        /// <summary>
        /// Folds and surrenders the game
        /// </summary>
        private void FoldButton_Click(object sender, EventArgs e)
        {
            Manager.Players[0].Fold();
            Close();
        }

        /// <summary>
        /// Allows a player to pick their best
        /// hand. (Used for bots)
        /// </summary>
        /// <param name="player">
        /// The player who is picking their best
        /// hand
        /// </param>
        public void PickBestHand(PokerPlayer player)
        {
            List<Card> BestFive = new(Manager.CommunityCards);

            foreach (Card card in player.PlayerHand.Cards)
                BestFive.Add(card);

            BestFive.Sort(new CardComparer());

            if(Hand.SpecialHand(BestFive, player))
            {
                Hand hand = new()
                {
                    Owner = player
                };

                hand.AddAll(BestFive);
                
                if(hand.RoyalFlush() || hand.StraightFlush() || hand.Straight() || hand.Flush())
                {
                    hand.RemoveCard(hand[^1]);
                    hand.RemoveCard(hand[^1]);
                } 
                else
                {
                    List<Card> removeCards = new(); // mark unneeded cards for removal
                    foreach(Card card in hand.Cards) 
                    {
                        if (hand.RemovalAffectsHand(card)) continue;
                        else if (hand.Cards.Count > 5) removeCards.Add(card);
                    }

                    foreach (Card card in removeCards) hand.RemoveCard(card);
                }

                BestFive = new List<Card>(hand.Cards);
                BestFive.Sort(new CardComparer());
                
                // Ensure there can be no more than 5
                // cards in the final hand
                if (BestFive.Count > 5)
                    while (BestFive.Count > 5)
                        BestFive.Remove(BestFive[^1]);
            }
            else
            {
                BestFive.Remove(BestFive[^1]);
                BestFive.Remove(BestFive[^1]);
            }

            player.PlayerHand.Cards.Clear();

            player.PlayerHand.AddAll(BestFive);

            Debugger.Log($"{player.Name} has chosen their best hand");
        }
    }
}

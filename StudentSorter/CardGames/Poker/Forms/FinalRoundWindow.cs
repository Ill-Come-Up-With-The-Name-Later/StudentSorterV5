using StudentSorter.Gambling.Cards;
using System.Data;
using StudentSorter.Debug;
using StudentSorter.CardGames.Poker.Player;
using StudentSorter.CardGames.Cards;

namespace StudentSorter.CardGames.Poker.Forms
{
    public partial class FinalRoundWindow : Form
    {
        public PokerManager Manager { get; set; }

        public DataTable PlayerCardTable = new();
        public DataTable CommunityCardTable = new();
        public DataTable BestHandTable = new();

        public List<Card> BestPlayerHand = new();

        public FinalRoundWindow(PokerManager manager)
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

            UpdateTables();
        }

        /// <summary>
        /// Removes a card from best
        /// player hand
        /// </summary>
        private void BestHandList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = CommunityCardList.CurrentCell.RowIndex;
            Card card = BestPlayerHand[index];

            BestPlayerHand.Remove(card);
            EndRoundButton.Enabled = false;

            UpdateTables();
        }

        /// <summary>
        /// Goes to final winner declaration window
        /// </summary>
        private void EndRoundButton_Click(object sender, EventArgs e)
        {
            Close();
            Manager.Players[0].PlayerHand.Cards.Clear();

            foreach(Card card in BestPlayerHand)
                Manager.Players[0].PlayerHand.AddCard(card);

            // All bots pick their 5 best cards
            foreach(PokerPlayer player in Manager.Players)
            {
                if (player.Folded || player.Name.Equals("Player")) continue;

                List<Card> BestFive = new(Manager.CommunityCards);

                foreach(Card card in player.PlayerHand.Cards)
                    BestFive.Add(card);

                BestFive.Sort(new CardComparer());

                BestFive.Remove(BestFive[^1]);
                BestFive.Remove(BestFive[^1]);

                player.PlayerHand.Cards.Clear();

                foreach(Card card in BestFive)
                    player.PlayerHand.AddCard(card);

                Debugger.Log($"{player.Name} has chosen their best hand");
            }

            WinnerWindow winnerWindow = new(Manager);
            winnerWindow.Show();
        }
    }
}

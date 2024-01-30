using StudentSorter.CardGames.Poker.Player;
using StudentSorter.Gambling.Cards;
using System.Data;
using StudentSorter.Debug;

namespace StudentSorter.CardGames.Poker.Forms
{
    public partial class PokerWindow : Form
    {
        public PokerManager Manager = new();
        public DataTable PlayerCardTable = new();

        public DataTable Player2CardTable = new();
        public DataTable Player3CardTable = new();
        public DataTable Player4CardTable = new();

        public DataTable CommunityCardTable = new();

        public PokerWindow()
        {
            InitializeComponent();

            PlayerCardTable.Columns.Add("Card", typeof(string));
            Player2CardTable.Columns.Add("Card", typeof(string));
            Player3CardTable.Columns.Add("Card", typeof(string));
            Player4CardTable.Columns.Add("Card", typeof(string));
            CommunityCardTable.Columns.Add("Card", typeof(string));

            PlayerCards.DataSource = PlayerCardTable;
            Player2Cards.DataSource = Player2CardTable;
            Player3Cards.DataSource = Player3CardTable;
            Player4Cards.DataSource = Player4CardTable;
            CommunityCards.DataSource = CommunityCardTable;

            Manager.SetupGame();

            Player2Label.Text = $"{Manager.Players[1].Name}'s Cards";
            Player3Label.Text = $"{Manager.Players[2].Name}'s Cards";
            Player4Label.Text = $"{Manager.Players[3].Name}'s Cards";
        }

        /// <summary>
        /// Starts the game
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            UpdatePlayerCards(Manager.Players[0], PlayerCardTable, PlayerCards);
            UpdatePlayerCards(Manager.Players[1], Player2CardTable, Player2Cards, true);
            UpdatePlayerCards(Manager.Players[2], Player3CardTable, Player3Cards, true);
            UpdatePlayerCards(Manager.Players[3], Player4CardTable, Player4Cards, true);

            BetWindow betWindow = new(this);
            betWindow.Show();

            StartButton.Enabled = false;
        }

        /// <summary>
        /// Updates the player's cards
        /// </summary>
        public void UpdatePlayerCards(PokerPlayer player, DataTable cardSource, DataGridView cards, bool obfuscate = false)
        {
            if (cardSource.Rows.Count > 0) cardSource.Rows.Clear();

            foreach (Card card in player.PlayerHand.Cards)
            {
                if (player.PlayerHand.Cards.IndexOf(card) > 0 && obfuscate)
                {
                    cardSource.Rows.Add("???");
                    continue;
                }

                cardSource.Rows.Add(card);
            }

            foreach (DataGridViewColumn col in cards.Columns)
                col.Width = cards.Width;

            Debugger.Log($"Updated card display of {player.Name}");
        }

        /// <summary>
        /// Updates the community card list
        /// </summary>
        public void UpdateCommunityCards()
        {
            if (CommunityCardTable.Rows.Count > 0) CommunityCardTable.Rows.Clear();

            foreach (Card card in Manager.CommunityCards)
                CommunityCardTable.Rows.Add(card);

            foreach (DataGridViewColumn col in CommunityCards.Columns)
                col.Width = CommunityCards.Width;

            Debugger.Log("Updated community card display");
        }

        /// <summary>
        /// Updates the bets for each player and the
        /// full betting pool
        /// </summary>
        public void UpdateBets()
        {
            Player1BetLabel.Text = $"Bet: {Manager.Players[0].Bet}";
            Player2BetLabel.Text = $"Bet: {Manager.Players[1].Bet}";
            Player3BetLabel.Text = $"Bet: {Manager.Players[2].Bet}";
            Player4BetLabel.Text = $"Bet: {Manager.Players[3].Bet}";

            PotLabel.Text = $"Pot: {Manager.Players[0].Bet + Manager.Players[1].Bet + Manager.Players[2].Bet + Manager.Players[3].Bet}";
        }
    }
}

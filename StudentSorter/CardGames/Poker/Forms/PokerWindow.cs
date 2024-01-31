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

            // If player has big blind or small blind
            if (Manager.Players[0].BigBlind || Manager.Players[0].SmallBlind)
            {
                EndTurn(Manager.BetRound);
                Debugger.Log($"{Manager.Players[0].Name} has the big blind or small blind button");
            }

            if (!(Manager.Players[0].BigBlind || Manager.Players[0].SmallBlind))
            {
                BetWindow betWindow = new(this);
                betWindow.Show();
            }

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

        /// <summary>
        /// Checks to see if the bots folded
        /// </summary>
        public void CheckFolds()
        {
            if (Manager.Players[1].Folded)
                Player2Label.Text = $"{Manager.Players[1].Name} (Folded)";

            if (Manager.Players[2].Folded)
                Player3Label.Text = $"{Manager.Players[2].Name} (Folded)";

            if (Manager.Players[3].Folded)
                Player4Label.Text = $"{Manager.Players[3].Name} (Folded)";
        }

        /// <summary>
        /// Ends a turn
        /// </summary>
        /// <param name="turnNum">
        /// The current turn
        /// </param>
        public void EndTurn(int turnNum)
        {
            Debugger.Log($"Turn {Manager.BetRound} ended");

            if (turnNum == 1)
            {
                Manager.FirstTurn();
                UpdateBets();
                UpdateCommunityCards();
                CheckFolds();
            }
            else
            {
                Manager.BettingRound(Manager.BetRound);
                UpdateBets();
                UpdateCommunityCards();
                CheckFolds();
            }

            if (Manager.BetRound == 2)
                Round2Button.Enabled = true;

            if (Manager.BetRound == 3)
                Round3Button.Enabled = true;

            Debugger.Log($"Started turn {Manager.BetRound}");
            BettingRoundLabel.Text = $"Betting Round: {(Manager.BetRound <= 3 ? Manager.BetRound : "Betting Over")}";
        }

        /// <summary>
        /// Goes to round 2 of betting
        /// </summary>
        private void Round2Button_Click(object sender, EventArgs e)
        {
            Round2Button.Enabled = false;

            BetWindow betWindow = new(this);
            betWindow.Show();
        }

        /// <summary>
        /// Goes to third, technically fourth and
        /// final round of bets
        /// </summary>
        private void Round3Button_Click(object sender, EventArgs e)
        {
            Round3Button.Enabled = false;

            BetWindow betWindow = new(this);
            betWindow.Show();
        }
    }
}

using StudentSorter.CardGames.Baccarat.Player;
using StudentSorter.Gambling.Cards;
using System.Data;
using StudentSorter.Debug;
using System.DirectoryServices.ActiveDirectory;

namespace StudentSorter.CardGames.Baccarat.Forms
{
    public partial class BaccaratWindow : Form
    {
        public BaccaratManager Manager;
        public DataTable Player1Cards = new();
        public DataTable Player2Cards = new();

        public BaccaratWindow()
        {
            InitializeComponent();

            BaccaratPlayer Player1 = new("Player");
            BaccaratPlayer Player2 = new("Real Human");
            Manager = new(Player1, Player2);

            Player1Cards.Columns.Add("Card", typeof(string));
            Player2Cards.Columns.Add("Card", typeof(string));

            Player1Hand.DataSource = Player1Cards;
            Player2Hand.DataSource = Player2Cards;

            Player1Title.Text = $"{Manager.Player1.Name}'s Hand";
            Player2Title.Text = $"{Manager.Player2.Name}'s Hand";

            Debugger.Log("Baccart opened");
        }

        /// <summary>
        /// Updates tables in UI to
        /// show cards and values
        /// </summary>
        public void UpdateTables()
        {
            if (Player1Cards.Rows.Count > 0) Player1Cards.Rows.Clear();
            if (Player2Cards.Rows.Count > 0) Player2Cards.Rows.Clear();

            foreach (Card card in Manager.Player1.PlayerHand.Cards)
                Player1Cards.Rows.Add(card);

            foreach (Card card in Manager.Player2.PlayerHand.Cards)
                Player2Cards.Rows.Add(card);

            foreach (DataGridViewColumn column in Player1Hand.Columns)
                column.Width = Player1Hand.Width;

            foreach (DataGridViewColumn column in Player2Hand.Columns)
                column.Width = Player2Hand.Width;

            Player1HandValue.Text = $"Hand Value: {Manager.Player1.PlayerHand.GetHandValue()}";
            Player2HandValue.Text = $"Hand Value: {Manager.Player2.PlayerHand.GetHandValue()}";

            Debugger.Log("Updated tables and hand values");
        }

        /// <summary>
        /// Starts the game
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;

            Manager.SetupGame();
            UpdateTables();
            Debugger.Log("Baccarat Started");

            ThirdCardPolicy();
        }

        /// <summary>
        /// Performs actions related to a
        /// third card for one or both players
        /// if needed
        /// </summary>
        public void ThirdCardPolicy()
        {
            // only go to third card if both players got 7 or less
            if (!(Manager.Player1.PlayerHand.GetHandValue() >= 8 && Manager.Player2.PlayerHand.GetHandValue() >= 8))
            {
                if(Player1TakeThirdCard())
                {
                    Manager.AddCard(Manager.Player1);
                    Debugger.Log($"{Manager.Player1.Name} was given a third card");
                }

                if(Player2TakeThirdCard())
                {
                    Manager.AddCard(Manager.Player2);
                    Debugger.Log($"{Manager.Player2.Name} was given a third card");
                }
            }
            UpdateTables();

            BaccaratPlayer? winner = Winner();

            WinnerWindow? winnerWindow = new(this, winner);
            winnerWindow.Show();
        }

        /// <summary>
        /// Determines if the player gets a third
        /// card
        /// </summary>
        /// <returns>
        /// True if the player gets a third card
        /// (if their hand's value is less than
        /// or equal to 5)
        /// </returns>
        public bool Player1TakeThirdCard()
        {
            return Manager.Player1.PlayerHand.GetHandValue() <= 5;
        }

        /// <summary>
        /// Determines if player 2 should
        /// take a card based on a more complex
        /// ruleset
        /// </summary>
        /// <returns>
        /// If player 2 takes a card
        /// </returns>
        public bool Player2TakeThirdCard()
        {
            if (Manager.Player1.PlayerHand.Cards.Count == 2)
                return Manager.Player2.PlayerHand.GetHandValue() <= 5;

            if (Manager.Player2.PlayerHand.GetHandValue() <= 2) return true;
            if (Manager.Player2.PlayerHand.GetHandValue() == 3) return !(Manager.Player1.PlayerHand.Cards[2].Value == 8);
            if (Manager.Player2.PlayerHand.GetHandValue() == 4) return Manager.Player1.PlayerHand.Cards[2].Value <= 7 &&
                    Manager.Player1.PlayerHand.Cards[2].Value >= 2;
            if (Manager.Player2.PlayerHand.GetHandValue() == 5) return Manager.Player1.PlayerHand.Cards[2].Value <= 7 &&
                    Manager.Player1.PlayerHand.Cards[2].Value >= 4;
            if (Manager.Player2.PlayerHand.GetHandValue() == 6) return Manager.Player1.PlayerHand.Cards[2].Value == 6 ||
                     Manager.Player1.PlayerHand.Cards[2].Value == 7;
            if (Manager.Player2.PlayerHand.GetHandValue() == 7) return false;

            return false;
        }

        /// <summary>
        /// Determines who won
        /// </summary>
        /// <returns>
        /// Whoever had closer to or equal to
        /// 9, or null if there was a tie
        /// </returns>
        public BaccaratPlayer? Winner()
        {
            return Manager.Player1.PlayerHand.GetHandValue() > Manager.Player2.PlayerHand.GetHandValue() ? Manager.Player1 :
                Manager.Player1.PlayerHand.GetHandValue() == Manager.Player2.PlayerHand.GetHandValue() ? null : Manager.Player2;
        }
    }
}

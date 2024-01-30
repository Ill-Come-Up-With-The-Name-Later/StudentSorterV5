using StudentSorter.Gambling.Cards;
using System.Data;

namespace StudentSorter.CardGames.Poker.Forms
{
    public partial class PokerWindow : Form
    {
        public PokerManager Manager = new();
        public DataTable PlayerCardTable = new();

        public PokerWindow()
        {
            InitializeComponent();
            PlayerCardTable.Columns.Add("Card", typeof(string));

            PlayerCards.DataSource = PlayerCardTable;
        }

        /// <summary>
        /// Starts the game
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            Manager.SetupGame();
            UpdatePlayerCards();
            


            StartButton.Enabled = false;
        }

        /// <summary>
        /// Updates the player's cards
        /// </summary>
        public void UpdatePlayerCards()
        {
            if (PlayerCardTable.Rows.Count > 0) PlayerCardTable.Rows.Clear();

            foreach (Card card in Manager.Players[0].PlayerHand.Cards)
                PlayerCardTable.Rows.Add(card);

            foreach (DataGridViewColumn col in PlayerCards.Columns)
                col.Width = PlayerCards.Width;
        }
    }
}

using System.Data;
using StudentSorter.Debug;
using StudentSorter.Gambling.Cards;

namespace StudentSorter.CardGames.Poker.FiveCardDraw.Forms
{
    public partial class FiveCardDrawWindow : Form
    {
        public DrawManager Manager = new();
        public DataTable PlayerHand = new();
        public DataTable Players = new();

        public FiveCardDrawWindow()
        {
            InitializeComponent();
            Manager.SetupGame();

            PlayerHand.Columns.Add("Card", typeof(string));
            PlayerCards.DataSource = PlayerHand;

            Players.Columns.Add("Name", typeof(string));
            PlayerList.DataSource = Players;

            Debugger.Log("Opened 5-Card Draw");
            UpdatePlayerList();
            UpdatePlayerCards();
        }

        /// <summary>
        /// Updates the player list
        /// </summary>
        public void UpdatePlayerList()
        {
            if(Players.Rows.Count > 0) Players.Rows.Clear();
            
            for(int i = 1; i < Manager.Players.Count; i++)
                Players.Rows.Add(Manager.Players[i].Name);

            foreach (DataGridViewColumn column in PlayerList.Columns)
                column.Width = PlayerList.Width;

            Debugger.Log("Updated player list");
        }

        /// <summary>
        /// Updates display for the player's cards
        /// </summary>
        public void UpdatePlayerCards()
        {
            if (PlayerHand.Rows.Count > 0) PlayerHand.Rows.Clear();

            foreach (Card card in Manager.Players[0].PlayerHand.Cards)
                PlayerHand.Rows.Add(card);

            foreach (DataGridViewColumn column in PlayerCards.Columns)
                column.Width = PlayerCards.Width;

            Debugger.Log("Updated player card display");
        }
    }
}

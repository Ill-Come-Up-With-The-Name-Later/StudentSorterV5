using System.Data;
using StudentSorter.CardGames.Cards;
using StudentSorter.Debug;

namespace StudentSorter.CardGames.Poker.FiveCardDraw.Forms
{
    public partial class FiveCardDrawWindow : Form
    {
        public DrawManager Manager = new();
        public DataTable PlayerHand = new();
        public DataTable Players = new();

        public bool DiscardMode;

        public FiveCardDrawWindow()
        {
            InitializeComponent();
            Manager.SetupGame();

            DiscardMode = false;

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
            if (Players.Rows.Count > 0) Players.Rows.Clear();

            for (int i = 1; i < Manager.Players.Count; i++)
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
            Manager.Players[0].PlayerHand.Cards.Sort(new CardComparer());

            if (PlayerHand.Rows.Count > 0) PlayerHand.Rows.Clear();

            foreach (Card card in Manager.Players[0].PlayerHand.Cards)
                PlayerHand.Rows.Add(card);

            foreach (DataGridViewColumn column in PlayerCards.Columns)
                column.Width = PlayerCards.Width;

            Debugger.Log("Updated player card display");
        }

        /// <summary>
        /// Opens window to allow you to discard cards
        /// and get new ones
        /// </summary>
        private void DiscardButton_Click(object sender, EventArgs e)
        {
            DiscardMode = true;
            DiscardButton.Enabled = false;
            DoneButton.Enabled = true;
            Instructions.Visible = true;
            PassButton.Enabled = false;

            Debugger.Log("Player chooses to discard");
            Manager.BotDiscard();
        }

        /// <summary>
        /// Skips player discarding cards
        /// </summary>
        private void PassButton_Click(object sender, EventArgs e)
        {
            DiscardButton.Enabled = false;
            Debugger.Log("Player stood and didn't discard");

            Manager.BotDiscard();

            ShowdownButton.Enabled = true;
        }

        /// <summary>
        /// Folds and closes the window
        /// </summary>
        private void FoldButton_Click(object sender, EventArgs e)
        {
            Manager.Players[0].Fold();
            Close();
        }

        /// <summary>
        /// Discards cards if the window
        /// is in discard mode
        /// </summary>
        private void PlayerCards_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!DiscardMode) return;

            if (Manager.Players[0].PlayerHand.ContainsAce())
            {
                if (Manager.Players[0].PlayerHand.Cards.Count < 2) return;
            }
            else
            {
                if (Manager.Players[0].PlayerHand.Cards.Count < 3) return;
            }

            int index = PlayerCards.CurrentCell.RowIndex;
            Card card = Manager.Players[0].PlayerHand.Cards[index];

            Manager.Players[0].RemoveCard(card);

            UpdatePlayerCards();
        }

        /// <summary>
        /// Finish discarding cards, get 
        /// new cards, and then go to showdown
        /// </summary>
        private void DoneButton_Click(object sender, EventArgs e)
        {
            DiscardMode = false;
            DoneButton.Enabled = false;

            while (Manager.Players[0].PlayerHand.Cards.Count < 5)
                Manager.AddCard(Manager.Players[0]);

            Debugger.Log("Player finished discarding");
            UpdatePlayerCards();

            ShowdownButton.Enabled = true;
        }

        /// <summary>
        /// Goes to the showdown
        /// </summary>
        private void ShowdownButton_Click(object sender, EventArgs e)
        {
            ShowdownWindow window = new(Manager);
            window.Show();

            Close();
        }
    }
}

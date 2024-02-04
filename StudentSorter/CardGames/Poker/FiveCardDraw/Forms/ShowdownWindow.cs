using StudentSorter.CardGames.Poker.Player;
using StudentSorter.Gambling.Cards;
using System.Data;
using StudentSorter.Debug;

namespace StudentSorter.CardGames.Poker.FiveCardDraw.Forms
{
    public partial class ShowdownWindow : Form
    {
        public DrawManager Manager;
        public DataTable PlayerHand = new();
        public int SelectedIndex;

        public ShowdownWindow(DrawManager manager)
        {
            InitializeComponent();
            Manager = manager;

            PlayerHand.Columns.Add("Card", typeof(string));
            SelectedIndex = 0;
            PlayerCards.DataSource = PlayerHand;

            // Determine winner
            PokerPlayer winner = Winner();

            // Show winner
            SelectedIndex = Manager.Players.IndexOf(winner);
            UpdatePlayerCardDisplay(SelectedIndex);
            WinnerLabel.Text = $"Winner: {winner.Name}";

            Debugger.Log("Showdown and finding winner done");
        }

        /// <summary>
        /// Updates the display to show
        /// a player's hand
        /// </summary>
        /// <param name="index">
        /// The index to show
        /// </param>
        public void UpdatePlayerCardDisplay(int index)
        {
            PokerPlayer player = Manager.Players[index];
            PlayerCardTitle.Text = $"{player.Name}'s Hand";

            if (PlayerHand.Rows.Count > 0) PlayerHand.Rows.Clear();

            foreach (Card card in player.PlayerHand.Cards)
                PlayerHand.Rows.Add(card);

            foreach (DataGridViewColumn column in PlayerCards.Columns)
                column.Width = PlayerCards.Width;

            Debugger.Log("Updated card display");
        }

        /// <summary>
        /// Determines the winner of 5-Card Draw
        /// </summary>
        /// <returns>
        /// The winner of the 5-Card Draw game
        /// </returns>
        public PokerPlayer Winner()
        {
            List<Hand> playerHands = new();

            foreach (PokerPlayer player in Manager.Players)
            {
                if (player.Folded) continue;

                playerHands.Add(player.PlayerHand);
            }

            playerHands.Sort(new HandComparer());
            Debugger.Log($"{playerHands[0].Owner.Name} won");

            return playerHands[0].Owner;
        }

        /// <summary>
        /// Cycles forwards through the player
        /// list
        /// </summary>
        private void NextHandButton_Click(object sender, EventArgs e)
        {
            SelectedIndex++;
            if (SelectedIndex >= Manager.Players.Count) SelectedIndex = 0;

            UpdatePlayerCardDisplay(SelectedIndex);
        }

        /// <summary>
        /// Cycles backwards through the player
        /// list
        /// </summary>
        private void PreviousHandButton_Click(object sender, EventArgs e)
        {
            SelectedIndex--;
            if (SelectedIndex < 0) SelectedIndex = Manager.Players.Count - 1;

            UpdatePlayerCardDisplay(SelectedIndex);
        }
    }
}

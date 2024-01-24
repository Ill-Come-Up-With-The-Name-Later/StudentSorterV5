namespace StudentSorter.Gambling.BlackJack.Forms
{
    public partial class WinnerWindow : Form
    {
        private readonly Player? Winner;
        private readonly GameWindow FormParent;

        public WinnerWindow(Player player, GameWindow formParent)
        {
            InitializeComponent();
            Winner = player;

            if (Winner == null)
            {
                WinnerTitle.Text = "Tie.";
            }
            else
            {
                WinnerTitle.Text = $"{Winner.Name} wins.";
            }

            FormParent = formParent;
        }

        /// <summary>
        /// Restarts a new blackjack game
        /// </summary>
        private void ReplayButton_Click(object sender, EventArgs e)
        {
            Close();
            FormParent.Close();
            GameWindow game = new();
            game.Show();
        }

        /// <summary>
        /// Closes the blackjack game
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            FormParent.Close();
            Close();
        }
    }
}

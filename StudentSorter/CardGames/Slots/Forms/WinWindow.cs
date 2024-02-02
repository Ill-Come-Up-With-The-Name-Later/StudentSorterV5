namespace StudentSorter.CardGames.Slots.Forms
{
    public partial class WinWindow : Form
    {
        public bool Win;
        public bool Jackpot;
        public SlotsWindow FormParent;

        public WinWindow(SlotsWindow formParent, bool win, bool jackpot)
        {
            InitializeComponent();

            Win = win;
            Jackpot = jackpot;
            FormParent = formParent;

            if (Win)
                WinLabel.Text = "You win!";

            if (Jackpot)
                WinLabel.Text = "You won the jackpot!";
        }

        /// <summary>
        /// Closes the window
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
            FormParent.Close();
        }

        /// <summary>
        /// Replays the slots
        /// </summary>
        private void ReplayButton_Click(object sender, EventArgs e)
        {
            Close();
            FormParent.Close();

            SlotsWindow window = new();
            window.Show();
        }
    }
}

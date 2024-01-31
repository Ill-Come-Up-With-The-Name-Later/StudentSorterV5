namespace StudentSorter.CardGames.Poker.Forms
{
    public partial class BetWindow : Form
    {
        public PokerWindow FormParent;

        public BetWindow(PokerWindow formParent)
        {
            InitializeComponent();
            FormParent = formParent;

            BetInput.Minimum = 100;
        }

        /// <summary>
        /// Enters a bet and plays the first turn
        /// </summary>
        private void BetButton_Click(object sender, EventArgs e)
        {
            FormParent.Manager.Players[0].SetBet((int)(FormParent.Manager.Players[0].Bet + BetInput.Value), FormParent.Manager);
            
            Close();
            FormParent.EndTurn(FormParent.Manager.BetRound);
            FormParent.UpdateBets();
            FormParent.CheckFolds();

            // Go to final showdown, highest hand wins
            if(FormParent.Manager.BetRound - 1 == 3)
            {
                FormParent.WindowState = FormWindowState.Minimized;
            }
        }
    }
}

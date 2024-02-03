using StudentSorter.CardGames.Baccarat.Player;
using StudentSorter.Debug;

namespace StudentSorter.CardGames.Baccarat.Forms
{
    public partial class WinnerWindow : Form
    {
        public BaccaratWindow FormParent { get; set; }
        public BaccaratPlayer? Winner;

        public WinnerWindow(BaccaratWindow window, BaccaratPlayer winner)
        {
            InitializeComponent();

            FormParent = window;
            Winner = winner;

            if (Winner == null) WinnerTitle.Text = "Game was a tie.";
            else WinnerTitle.Text = $"{Winner.Name} won!";
        }

        /// <summary>
        /// Closes Baccarat
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
            FormParent.Close();

            Debugger.Log("Closed Baccarat");
        }

        /// <summary>
        /// Replays Baccarat
        /// </summary>
        private void ReplayButton_Click(object sender, EventArgs e)
        {
            FormParent.Close();
            Close();

            BaccaratWindow window = new();
            window.Show();

            Debugger.Log("Replaying Baccarat");
        }
    }
}

using StudentSorter.CardGames.Poker.Forms;
using StudentSorter.Debug;
using StudentSorter.Gambling.BlackJack.Forms;

namespace StudentSorter.CardGames
{
    public partial class CardGameMenu : Form
    {
        public CardGameMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens Blackjack
        /// </summary>
        private void BlackjackButton_Click(object sender, EventArgs e)
        {
            BlackjackWindow window = new();
            window.Show();

            Debugger.Log("Opened Blackjack");
        }

        /// <summary>
        /// Opens Poker
        /// 
        /// Texas Hold'em variant
        /// </summary>
        private void PokerButton_Click(object sender, EventArgs e)
        {
            PokerWindow pokerWindow = new();
            pokerWindow.Show();

            Debugger.Log("Opened Poker (Texas Hold'em)");
        }
    }
}

using StudentSorter.CardGames.Baccarat.Forms;
using StudentSorter.CardGames.Keno.Forms;
using StudentSorter.CardGames.Poker.FiveCardDraw.Forms;
using StudentSorter.CardGames.Poker.Forms;
using StudentSorter.CardGames.Slots;
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

        /// <summary>
        /// Opens the slot machine emulation
        /// window
        /// </summary>
        private void SlotsButton_Click(object sender, EventArgs e)
        {
            SlotsWindow slotsWindow = new();
            slotsWindow.Show();
        }

        /// <summary>
        /// Opens Baccarat window
        /// </summary>
        private void BaccaratButton_Click(object sender, EventArgs e)
        {
            BaccaratWindow baccaratWindow = new();
            baccaratWindow.Show();
        }

        /// <summary>
        /// Opens 5-Card Draw window
        /// </summary>
        private void FiveCardDrawButton_Click(object sender, EventArgs e)
        {
            FiveCardDrawWindow window = new();
            window.Show();
        }

        /// <summary>
        /// Opens Keno
        /// </summary>
        private void KneoButton_Click(object sender, EventArgs e)
        {
            KenoWindow window = new();
            window.Show();
        }
    }
}

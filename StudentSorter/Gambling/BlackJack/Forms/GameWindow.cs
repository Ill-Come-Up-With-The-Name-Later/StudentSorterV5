namespace StudentSorter.Gambling.BlackJack.Forms
{
    public partial class GameWindow : Form
    {
        public GameManager Manager;

        public GameWindow()
        {
            InitializeComponent();

            Player p1 = new();
            Player p2 = new("Dealer");
            Manager = new(p1, p2);
        }

        /// <summary>
        /// Set up blackjack game
        /// </summary>
        private void GameWindow_Load(object sender, EventArgs e)
        {
            Manager.SetupGame();
        }
    }
}

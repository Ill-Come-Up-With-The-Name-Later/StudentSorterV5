using System.Data;

namespace StudentSorter.Gambling.BlackJack.Forms
{
    public partial class GameWindow : Form
    {
        public GameManager Manager;
        DataTable Player1Cards = new();
        DataTable Player2Cards = new();

        public GameWindow()
        {
            InitializeComponent();

            Player p1 = new();
            Player p2 = new("Dealer");
            Manager = new(p1, p2);

            Player1Hand.DataSource = Player1Cards;
            Player2Hand.DataSource = Player2Cards;
        }

        /// <summary>
        /// Set up blackjack game
        /// </summary>
        private void GameWindow_Load(object sender, EventArgs e)
        {
            Manager.SetupGame();
            Player1Title.Text = $"{Manager.Player1}'s Hand";
            Player2Title.Text = $"{Manager.Player2}'s Hand";

            Manager.UpdatePlayerCardList(Manager.Player1, Player1Cards);
            Manager.UpdatePlayerCardList(Manager.Player2, Player2Cards);
        }
    }
}

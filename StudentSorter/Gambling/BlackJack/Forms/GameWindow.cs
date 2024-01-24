using System.Data;

namespace StudentSorter.Gambling.BlackJack.Forms
{
    public partial class GameWindow : Form
    {
        public GameManager Manager;
        private readonly DataTable Player1Cards = new();
        private readonly DataTable Player2Cards = new();

        public GameWindow()
        {
            InitializeComponent();

            Player1Hand.DataSource = Player1Cards;
            Player2Hand.DataSource = Player2Cards;

            Player1Cards.Columns.Add("Cards", typeof(string));
            Player2Cards.Columns.Add("Cards", typeof(string));

            Player p1 = new("Player");
            Player p2 = new("Dealer");
            Manager = new(p1, p2);

            Player1Title.Text = $"{Manager.Player1}'s Hand";
            Player2Title.Text = $"{Manager.Player2}'s Hand";

            StartGame();
        }

        /// <summary>
        /// Starts the game
        /// </summary>
        public void StartGame()
        {
            Manager.SetupGame();
            GameManager.UpdatePlayerCardList(Manager.Player1, Player1Cards, Player1Hand);
            GameManager.UpdatePlayerCardList(Manager.Player2, Player2Cards, Player2Hand);
        }
    }
}

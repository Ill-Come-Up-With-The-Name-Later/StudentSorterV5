using System.Data;

namespace StudentSorter.Gambling.BlackJack.Forms
{
    public partial class GameWindow : Form
    {
        public GameManager Manager;
        public DataTable Player1Cards = new();
        public DataTable Player2Cards = new();
        private int Turn;

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

            Player1Title.Text = $"{Manager.Player1.Name}'s Hand";
            Player2Title.Text = $"{Manager.Player2.Name}'s Hand";

            StartGame();
        }

        /// <summary>
        /// Starts the game
        /// </summary>
        public void StartGame()
        {
            Manager.SetupGame();
            GameManager.UpdatePlayerCardList(Manager.Player1, Player1Cards, Player1Hand, HandValue);
            GameManager.UpdatePlayerCardList(Manager.Player2, Player2Cards, Player2Hand, new Label(), true);
            CheckWin();
            Turn = 1;
        }

        /// <summary>
        /// Draws a card
        /// </summary>
        private void DrawCardButton_Click(object sender, EventArgs e)
        {
            Manager.AddCard(Manager.Player1);
            GameManager.UpdatePlayerCardList(Manager.Player1, Player1Cards, Player1Hand, HandValue);
            Turn++;
            CheckWin();
        }

        /// <summary>
        /// Dealer draws a card
        /// </summary>
        private void PassButton_Click(object sender, EventArgs e)
        {
            // Instantly end if Dealer beat Player
            if (Manager.Player2.CardValue > Manager.Player1.CardValue && Manager.Player2.CardValue <= 21)
            {
                Player winner = Manager.Player2;
                WinnerWindow winWindow = new(winner, this);
                winWindow.WindowState = FormWindowState.Minimized;
                winWindow.Show();
                winWindow.WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Minimized;

                InProgLabel.Text = "Game Over";

                DrawCardButton.Enabled = false;
                PassButton.Enabled = false;

                return;
            }

            // Dealer keeps drawing to try to beat Player
            while (Manager.Player2.CardValue <= 17)
            {
                if (Manager.Player2.CardValue > Manager.Player1.CardValue)
                    break;

                Manager.AddCard(Manager.Player2);
                GameManager.UpdatePlayerCardList(Manager.Player2, Player2Cards, Player2Hand, new Label(), true);
                Turn++;
            }

            CheckWin(true);
        }

        /// <summary>
        /// Checks for a winner and will show
        /// the winner if there is one
        /// </summary>
        /// <param name="pStand">
        /// If the player stood (didn't take a card)
        /// </param>
        public void CheckWin(bool pStand = false)
        {
            if (Manager.Winner(Manager.Player1, Manager.Player2, Turn, pStand) != null)
            {
                Player winner = Manager.Winner(Manager.Player1, Manager.Player2, Turn, pStand);
                WinnerWindow winWindow = new(winner, this);

                winWindow.WindowState = FormWindowState.Minimized;
                winWindow.Show();
                winWindow.WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Minimized;

                InProgLabel.Text = "Game Over";

                DrawCardButton.Enabled = false;
                PassButton.Enabled = false;
            }
        }
    }
}

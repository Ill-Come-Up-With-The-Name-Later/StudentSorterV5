﻿using StudentSorter.CardGames.BlackJack;
using System.Data;

namespace StudentSorter.Gambling.BlackJack.Forms
{
    public partial class BlackjackWindow : Form
    {
        public BlackjackManager Manager;
        public DataTable Player1Cards = new();
        public DataTable Player2Cards = new();
        private int Turn;

        public BlackjackWindow()
        {
            InitializeComponent();

            Player1Hand.DataSource = Player1Cards;
            Player2Hand.DataSource = Player2Cards;

            Player1Cards.Columns.Add("Cards", typeof(string));
            Player2Cards.Columns.Add("Cards", typeof(string));

            BlackjackPlayer p1 = new("Player");
            BlackjackPlayer p2 = new("Dealer");
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
            BlackjackManager.UpdatePlayerCardList(Manager.Player1, Player1Cards, Player1Hand, HandValue);
            BlackjackManager.UpdatePlayerCardList(Manager.Player2, Player2Cards, Player2Hand, new Label(), true);
            CheckWin();
            Turn = 1;
        }

        /// <summary>
        /// Draws a card
        /// </summary>
        private void DrawCardButton_Click(object sender, EventArgs e)
        {
            Manager.AddCard(Manager.Player1);
            BlackjackManager.UpdatePlayerCardList(Manager.Player1, Player1Cards, Player1Hand, HandValue);
            Turn++;

            if(Manager.Player1.CardValue > 21)
            {
                ShowWinWindow(Manager.Player2);
            }

            // Stop getting cards
            if(Manager.Player1.CardValue == 21)
            {
                DrawCardButton.Enabled = false;
                PassButton.Enabled = false;

                DealerTurn();
            }

            //CheckWin();
        }

        /// <summary>
        /// Dealer draws a card
        /// </summary>
        private void PassButton_Click(object sender, EventArgs e)
        {
            // Instantly end if Dealer beat Player
            if (Manager.Player2.CardValue > Manager.Player1.CardValue && Manager.Player2.CardValue <= 21)
            {
                BlackjackPlayer winner = Manager.Player2;

                ShowWinWindow(winner);
                return;
            }

            // Dealer keeps drawing to try to beat Player
            DealerTurn();
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
                BlackjackPlayer winner = Manager.Winner(Manager.Player1, Manager.Player2, Turn, pStand);
                
                ShowWinWindow(winner);
            }
        }

        /// <summary>
        /// Displays the winner window
        /// </summary>
        /// <param name="winner">
        /// The winner
        /// </param>
        public void ShowWinWindow(BlackjackPlayer winner)
        {
            WinnerWindow winWindow = new(winner, this)
            {
                WindowState = FormWindowState.Minimized
            };

            winWindow.Show();
            winWindow.WindowState = FormWindowState.Normal;
            WindowState = FormWindowState.Minimized;

            InProgLabel.Text = "Game Over";

            DrawCardButton.Enabled = false;
            PassButton.Enabled = false;
        }

        /// <summary>
        /// Dealer plays and draws cards to try
        /// to beat the player
        /// </summary>
        public void DealerTurn()
        {
            while (Manager.Player2.CardValue <= 17 && (Manager.Player2.CardValue <= Manager.Player1.CardValue && Manager.Player2.CardValue <= 21))
            {
                if (Manager.Player2.CardValue > Manager.Player1.CardValue)
                    break;

                Manager.AddCard(Manager.Player2);
                BlackjackManager.UpdatePlayerCardList(Manager.Player2, Player2Cards, Player2Hand, new Label(), true);
              
                Turn++;
            }

            CheckWin(true);
        }
    }
}

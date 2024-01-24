using StudentSorter.Gambling.Cards;
using System.Data;
using StudentSorter.Debug;

namespace StudentSorter.Gambling.BlackJack.Forms
{
    public partial class WinnerWindow : Form
    {
        private readonly Player? Winner;
        private readonly GameWindow FormParent;
        private readonly DataTable DealerCardsRevealed = new();

        public WinnerWindow(Player player, GameWindow formParent)
        {
            InitializeComponent();
            FormParent = formParent;
            Winner = player;

            DealerCardLabel.Text = $"Dealer Cards - Hand Value: {FormParent.Manager.Player2.CardValue}";
            DealerCardList.DataSource = DealerCardsRevealed;

            DealerCardsRevealed.Columns.Add("Card", typeof(string));

            foreach(Card card in FormParent.Manager.Player2.Cards)
                DealerCardsRevealed.Rows.Add(card.ToString());

            foreach (DataGridViewColumn column in DealerCardList.Columns)
                column.Width = DealerCardList.Width;

            if (Winner == null)
            {
                WinnerTitle.Text = "Tie.";
                Debugger.Log("Game was a tie.");
            }
            else
            {
                WinnerTitle.Text = $"{Winner.Name} wins.";
                Debugger.Log($"{Winner.Name} won.");
            }
        }

        /// <summary>
        /// Restarts a new blackjack game
        /// </summary>
        private void ReplayButton_Click(object sender, EventArgs e)
        {
            Close();
            FormParent.Close();
            GameWindow game = new();
            game.Show();
            Debugger.Log("Replaying Blackjack");
        }

        /// <summary>
        /// Closes the blackjack game
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            FormParent.Close();
            Close();
        }
    }
}

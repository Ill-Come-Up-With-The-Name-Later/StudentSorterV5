using System.Data;
using StudentSorter.Debug;
using StudentSorter.CardGames.BlackJack;
using StudentSorter.CardGames.Cards;

namespace StudentSorter.Gambling.BlackJack.Forms
{
    public partial class WinnerWindow : Form
    {
        private readonly BlackjackPlayer? Winner;
        private readonly BlackjackWindow FormParent;
        private readonly DataTable DealerCardsRevealed = new();
        private readonly DataTable PlayerCards = new();

        public WinnerWindow(BlackjackPlayer player, BlackjackWindow formParent)
        {
            InitializeComponent();
            FormParent = formParent;
            Winner = player;

            // Load info about players' card values
            DealerCardLabel.Text = $"{FormParent.Manager.Player2.Name}'s Cards - Hand Value: {FormParent.Manager.Player2.CardValue}";
            PlayerCardLabel.Text = $"{FormParent.Manager.Player1.Name}'s Cards - Hand Value: {FormParent.Manager.Player1.CardValue}";
            DealerCardList.DataSource = DealerCardsRevealed;
            PlayerCardList.DataSource = PlayerCards;

            DealerCardsRevealed.Columns.Add("Card", typeof(string));
            PlayerCards.Columns.Add("Card", typeof(string));

            // Load and set up dealer cards display
            foreach (Card card in FormParent.Manager.Player2.Cards)
                DealerCardsRevealed.Rows.Add(card.ToString());

            foreach (DataGridViewColumn column in DealerCardList.Columns)
                column.Width = DealerCardList.Width;

            // Load and set up player cards display
            foreach (Card card in FormParent.Manager.Player1.Cards)
                PlayerCards.Rows.Add(card.ToString());

            foreach (DataGridViewColumn column in PlayerCardList.Columns)
                column.Width = PlayerCardList.Width;

            // Set winner title
            if (Winner == null || Winner.Name.Equals("No One"))
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
            BlackjackWindow game = new();
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

            Debugger.Log("Closed Blackjack");
        }
    }
}

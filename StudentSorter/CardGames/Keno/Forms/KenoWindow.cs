using System.Data;
using System.Text;
using StudentSorter.Debug;

namespace StudentSorter.CardGames.Keno.Forms
{
    public partial class KenoWindow : Form
    {
        public int NumberOfNums;
        public DataTable BetNums = new();
        public DataTable WinningNums = new();

        public List<int> PlayerNums = new();
        public List<int> DrawnNums = new();

        public KenoWindow()
        {
            NumberOfNums = 0;
            InitializeComponent();

            PlayerNumbers.DataSource = BetNums;
            DrawnNumbers.DataSource = WinningNums;

            BetNums.Columns.Add("Num", typeof(int));
            WinningNums.Columns.Add("Num", typeof(int));

            Debugger.Log("Opened Keno");
        }

        /// <summary>
        /// Updates the tables to show
        /// numbers
        /// </summary>
        public void UpdateTables()
        {
            if (BetNums.Rows.Count > 0) BetNums.Rows.Clear();
            if (WinningNums.Rows.Count > 0) WinningNums.Rows.Clear();

            foreach (int num in PlayerNums)
                BetNums.Rows.Add(num);

            foreach (int num in DrawnNums)
                WinningNums.Rows.Add(num);

            foreach (DataGridViewColumn col in PlayerNumbers.Columns)
                col.Width = PlayerNumbers.Width;

            foreach (DataGridViewColumn col in DrawnNumbers.Columns)
                col.Width = DrawnNumbers.Width;

            Debugger.Log("Tables updated");
        }

        /// <summary>
        /// Sets the amount of numbers the
        /// player is betting on
        /// </summary>
        private void SetAmountOfNumsButton_Click(object sender, EventArgs e)
        {
            NumberOfNums = (int)NumberAmountInput.Value;

            NumberAmountInput.Enabled = false;
            SetAmountOfNumsButton.Enabled = false;

            BetNumButton.Enabled = true;
            ChosenNumInput.Enabled = true;

            Debugger.Log($"Player is betting on {NumberOfNums} number(s)");
        }

        /// <summary>
        /// Bets on a number
        /// </summary>
        private void BetNumButton_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();

            if (PlayerNums.Count >= NumberOfNums)
            {
                ErrorProvider.SetError(BetNumButton, "You already bet as many numbers as you can");
                Debugger.Log("Player attempted to bet on too many numbers");

                BetNumButton.Enabled = false;
                ChosenNumInput.Enabled = false;
                DrawButton.Enabled = true;
                return;
            }

            if (PlayerNums.Contains((int)ChosenNumInput.Value))
            {
                ErrorProvider.SetError(BetNumButton, "You already bet this number");
                Debugger.Log("Player attempted to bet a number twice");
                return;
            }

            if (PlayerNums.Count + 1 == NumberOfNums)
            {
                BetNumButton.Enabled = false;
                ChosenNumInput.Enabled = false;
                DrawButton.Enabled = true;
            }

            PlayerNums.Add((int)ChosenNumInput.Value);
            Debugger.Log($"Player is betting on {ChosenNumInput.Value}");

            UpdateTables();
        }

        /// <summary>
        /// Draws 20 numbers from 1-80 without
        /// duplicates allowed
        /// </summary>
        private void DrawButton_Click(object sender, EventArgs e)
        {
            DrawButton.Enabled = false;

            for (int i = 0; i < 20; i++)
            {
                int winningNum = new Random().Next(1, 81);

                while (DrawnNums.Contains(winningNum))
                    winningNum = new Random().Next(1, 81);

                DrawnNums.Add(winningNum);
                Debugger.Log($"{winningNum} was drawn");
            }

            UpdateTables();
            MatchLabel.Text = $"Matches: {NumMatches()}/{PlayerNums.Count}";
        }

        /// <summary>
        /// Gets the number of matches
        /// between the player's bets and
        /// the winning numbers
        /// </summary>
        /// <returns>
        /// The amount of matches
        /// </returns>
        public int NumMatches()
        {
            int matches = 0;
            foreach (int i in PlayerNums)
                if (DrawnNums.Contains(i))
                    matches++;

            Debugger.Log($"{matches} match(es) found");
            return matches;
        }

        /// <summary>
        /// Closes Keno
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Replays Keno
        /// </summary>
        private void ReplayButton_Click(object sender, EventArgs e)
        {
            Close();

            KenoWindow window = new();
            window.Show();
        }
    }
}

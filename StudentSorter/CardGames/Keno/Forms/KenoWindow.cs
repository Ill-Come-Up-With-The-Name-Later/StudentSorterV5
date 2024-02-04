using System.Data;
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
            if(BetNums.Rows.Count > 0) BetNums.Rows.Clear();
            if(WinningNums.Rows.Count > 0) WinningNums.Rows.Clear();

            foreach(int num in PlayerNums)
                BetNums.Rows.Add(num);

            foreach (int num in DrawnNums) 
                WinningNums.Rows.Add(num);

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
                return;
            }

            PlayerNums.Add((int)ChosenNumInput.Value);
            Debugger.Log($"Player is betting on {ChosenNumInput.Value}");

            UpdateTables();
        }
    }
}

using StudentSorter.CardGames.Baccarat.Player;
using StudentSorter.Gambling.Cards;
using System.Data;
using StudentSorter.Debug;

namespace StudentSorter.CardGames.Baccarat.Forms
{
    public partial class BaccaratWindow : Form
    {
        public BaccaratManager Manager;
        public DataTable Player1Cards = new();
        public DataTable Player2Cards = new();

        public BaccaratWindow()
        {
            InitializeComponent();

            BaccaratPlayer Player1 = new("Player");
            BaccaratPlayer Player2 = new("Real Human");
            Manager = new(Player1, Player2);

            Manager.SetupGame();

            Player1Cards.Columns.Add("Card", typeof(string));
            Player2Cards.Columns.Add("Card", typeof(string));

            Player1Hand.DataSource = Player1Cards;
            Player2Hand.DataSource = Player2Cards;

            Player1Title.Text = $"{Manager.Player1.Name}'s Hand";
            Player2Title.Text = $"{Manager.Player2.Name}'s Hand";

            Debugger.Log("Baccart opened and started");

            UpdateTables();
        }

        /// <summary>
        /// Updates tables in UI to
        /// show cards and values
        /// </summary>
        public void UpdateTables()
        {
            foreach (Card card in Manager.Player1.PlayerHand.Cards)
                Player1Cards.Rows.Add(card);

            foreach (Card card in Manager.Player2.PlayerHand.Cards)
                Player2Cards.Rows.Add(card);

            foreach (DataGridViewColumn column in Player1Hand.Columns)
                column.Width = Player1Hand.Width;

            foreach (DataGridViewColumn column in Player2Hand.Columns)
                column.Width = Player2Hand.Width;

            Player1HandValue.Text = $"Hand Value: {Manager.Player1.PlayerHand.GetHandValue()}";
            Player2HandValue.Text = $"Hand Value: {Manager.Player2.PlayerHand.GetHandValue()}";

            Debugger.Log("Updated tables and hand values");
        }
    }
}

namespace StudentSorter.CardGames.Poker.Forms
{
    public partial class BetWindow : Form
    {
        public PokerWindow FormParent;

        public BetWindow(PokerWindow formParent)
        {
            InitializeComponent();
            FormParent = formParent;
        }

    }
}

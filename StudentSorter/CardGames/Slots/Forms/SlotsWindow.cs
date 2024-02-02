using StudentSorter.Debug;

namespace StudentSorter.CardGames.Slots
{
    public partial class SlotsWindow : Form
    {
        public List<char> Symbols = new()
        {
            'α',
            'β',
            'γ',
            'Γ',
            'δ',
            'Δ',
            'ε',
            'ζ',
            'η',
            'θ',
            'Θ',
            'ι',
            'κ',
            'λ',
            'Λ',
            'μ',
            'ξ',
            'Ξ',
            'π',
            'Π',
            'ρ',
            'ς',
            'σ',
            'Σ',
            'Φ',
            'φ',
            'Ψ',
            'ψ',
            'ω',
            'Ω'
        };

        public char JackpotSymbol = 'α';

        /// <summary>
        /// Technically not a card game, but it
        /// is in the category of casino gambling games
        /// </summary>
        public SlotsWindow()
        {
            InitializeComponent();

            Debugger.Log("Opened (Lucky) Slot machine");
        }

        /// <summary>
        /// Floats the symbols around in the boxes
        /// </summary>
        private void SlotMachineTimer_Tick(object sender, EventArgs e)
        {
            char firstSymbol = Symbols[new Random().Next(0, Symbols.Count)];
            char secondSymbol = Symbols[new Random().Next(0, Symbols.Count)];
            char thirdSymbol = Symbols[new Random().Next(0, Symbols.Count)];


        }

        /// <summary>
        /// Spins the slot machine
        /// </summary>
        private void SpinButton_Click(object sender, EventArgs e)
        {

        }
    }
}

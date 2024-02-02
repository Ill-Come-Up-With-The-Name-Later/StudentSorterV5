using StudentSorter.Debug;

namespace StudentSorter.CardGames.Slots
{
    public partial class SlotsWindow : Form
    {
        public int tick;

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

        public const int NumSpins = 45;

        /// <summary>
        /// Technically not a card game, but it
        /// is in the category of casino gambling games
        /// </summary>
        public SlotsWindow()
        {
            InitializeComponent();

            Debugger.Log("Opened (Lucky) Slot machine");
            SlotMachineTimer.Stop();
            tick = 0;
        }

        /// <summary>
        /// Floats the symbols around in the boxes
        /// </summary>
        private void SlotMachineTimer_Tick(object sender, EventArgs e)
        {
            if (tick >= NumSpins)
            {
                SlotMachineTimer.Stop();
                return;
            }

            tick += 1;

            UpdateSymbols();
            Debugger.Log($"Tick: {tick}");
        }

        /// <summary>
        /// Spins the slot machine for a
        /// certain amount of time
        /// </summary>
        private void SpinButton_Click(object sender, EventArgs e)
        {
            SlotMachineTimer.Stop();
            tick = 0;

            SlotMachineTimer.Start();

            Debugger.Log("Started Spin");
        }

        /// <summary>
        /// Updates the symbols in the slots
        /// </summary>
        public void UpdateSymbols()
        {
            char firstSymbol = Symbols[new Random().Next(0, Symbols.Count)];
            char secondSymbol = Symbols[new Random().Next(0, Symbols.Count)];
            char thirdSymbol = Symbols[new Random().Next(0, Symbols.Count)];

            Symbol1.Text = firstSymbol.ToString();
            Symbol2.Text = secondSymbol.ToString();
            Symbol3.Text = thirdSymbol.ToString();

            Debugger.Log("Updated slot symbols");
        }
    }
}

namespace StudentSorter.CardGames.Poker.Player
{
    public class PokerPlayer
    {
        public Hand PlayerHand = new();
        public string Name { get; set; }
        public bool Dealer {  get; set; }
        public bool BigBlind {  get; set; }
        public bool SmallBlind {  get; set; }
        public int Bet {  get; set; }
        public bool Folded {  get; set; }

        /// <summary>
        /// A player in a poker game
        /// </summary>
        /// <param name="name">
        /// The name of the player
        /// </param>
        public PokerPlayer(string name = "Player")
        {
            Name = name;
            
            Dealer = false;
            BigBlind = false;
            SmallBlind = false;
            Folded = false;

            Bet = 0;
        }

        /// <summary>
        /// Folds, surrenders all cards and leaves
        /// game
        /// </summary>
        public void Fold() { Folded = true; }

        /// <summary>
        /// Adds a bet
        /// </summary>
        /// <param name="manager">
        /// GameManager to use for the bet
        /// </param>
        public void SetBet(int bet, PokerManager manager)
        {
            Bet = bet;
            manager.Pot += Bet;
        }

        public override string ToString()
        {
            return $"{Name}: Dealer: {Dealer} | Big Blind: {BigBlind} | Small Blind: {SmallBlind}";
        }
    }
}

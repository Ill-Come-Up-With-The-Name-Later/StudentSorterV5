namespace StudentSorter.CardGames.Poker.Player
{
    public class PokerPlayer
    {
        public Hand PlayerHand = new();
        public string Name { get; set; }

        public bool Dealer { get; set; }
        public bool SmallBlind { get; set; }
        public bool BigBlind { get; set; }

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
            SmallBlind = false;
            BigBlind = false;
        }

        public override string ToString()
        {
            string player = $"{Name}";

            if(Dealer)
                player += $" [Dealer]";

            if(SmallBlind)
                player += $" [Small Blind]";

            if (BigBlind)
                player += $" [Big Blind]";

            return player;
        }
    }
}

namespace StudentSorter.CardGames.Poker
{
    public class PokerPlayer
    {
        public Hand PlayerHand = new();
        public string Name { get; set; }

        /// <summary>
        /// A player in a poker game
        /// </summary>
        /// <param name="name">
        /// The name of the player
        /// </param>
        public PokerPlayer(string name = "Player") { Name = name; }
    }
}

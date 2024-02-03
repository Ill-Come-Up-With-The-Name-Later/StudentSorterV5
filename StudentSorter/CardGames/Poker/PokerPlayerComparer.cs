using StudentSorter.CardGames.Poker.Player;

namespace StudentSorter.CardGames.Poker
{
    internal class PokerPlayerComparer : IComparer<PokerPlayer>
    {
        /// <summary>
        /// Compares two poker players
        /// </summary>
        /// <param name="x">
        /// The first player
        /// </param>
        /// <param name="y">
        /// The second player
        /// </param>
        /// <returns>
        /// Where to place the player in the list
        /// </returns>
        public int Compare(PokerPlayer? x, PokerPlayer? y)
        {
            if (x == null || y == null) return 0;
            if (x.PlayerHand.GetHandValue() == y.PlayerHand.GetHandValue()) return 0;
            if (x.PlayerHand.GetHandValue() > y.PlayerHand.GetHandValue()) return -1;
            if (x.PlayerHand.GetHandValue() < y.PlayerHand.GetHandValue()) return 1;
            return 0;
        }
    }
}

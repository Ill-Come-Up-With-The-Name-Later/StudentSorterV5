using StudentSorter.Gambling.Cards;

namespace StudentSorter.CardGames.Cards
{
    class CardShuffler : IComparer<Card>
    {
        /// <summary>
        /// Used to shuffle a deck of cards
        /// </summary>
        /// <param name="x">
        /// The first card
        /// </param>
        /// <param name="y">
        /// The second card
        /// </param>
        /// <returns>
        /// -1, 0, or 1 if neither card is null
        /// </returns>
        public int Compare(Card? x, Card? y)
        {
            if (x == null || y == null) return 0;
            return new Random().Next(-1, 2);
        }
    }
}

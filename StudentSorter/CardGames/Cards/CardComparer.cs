namespace StudentSorter.CardGames.Cards
{
    public class CardComparer : IComparer<Card>
    {
        /// <summary>
        /// Compares two cards by their value
        /// </summary>
        /// <param name="x">
        /// A card
        /// </param>
        /// <param name="y">
        /// A card
        /// </param>
        /// <returns>
        /// If the cards are the same value, greater than, or less than
        /// each other
        /// </returns>
        public int Compare(Card? x, Card? y)
        {
            if (x == null || y == null) return 0;
            if(x.Value == y.Value) return 0;
            if(x.Value < y.Value) return 1;
            if(x.Value > y.Value) return -1;

            return 0;
        }
    }
}

using StudentSorter.CardGames.Baccarat.Player;

namespace StudentSorter.CardGames.Baccarat
{
    public class BaccaratHandComparer : IComparer<Hand>
    {

        /// <summary>
        /// Ranks the hands' values
        /// </summary>
        /// <param name="x">
        /// A hand
        /// </param>
        /// <param name="y">
        /// A hand
        /// </param>
        /// <returns>
        /// If hand x should be before hand y in a
        /// sorted list
        /// </returns>
        public int Compare(Hand? x, Hand? y)
        {
            if(x == null || y == null) return 0;
            if(x.GetHandValue() < y.GetHandValue()) return 1;
            if(x.GetHandValue() > y.GetHandValue()) return -1;
            if(x.GetHandValue()==y.GetHandValue()) return 0;

            return 0;
        }
    }
}

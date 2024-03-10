using StudentSorter.CardGames.Cards;

namespace StudentSorter.CardGames.Baccarat.Player
{
    public class Hand
    {
        public BaccaratPlayer Owner;
        public List<Card> Cards = new();

        public Hand()
        {
        }

        /// <summary>
        /// Gets the value of the hand
        /// </summary>
        /// <returns>
        /// The hand's value
        /// </returns>
        public int GetHandValue()
        {
            int val = 0;

            foreach(Card card in Cards)
                val+= card.Value;

            if(val >= 10) val -= 10;

            if (val >= 10) val = 9;

            return val;
        }
    }
}

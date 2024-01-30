using StudentSorter.Gambling.Cards;

namespace StudentSorter.CardGames.Poker
{
    public class Hand
    {
        public List<Card> cards = new();

        /// <summary>
        /// A hand of cards
        /// </summary>
        public Hand() { }

        /// <summary>
        /// Gets the value of this hand
        /// </summary>
        /// <returns>
        /// The value of the hand
        /// </returns>
        public int GetHandValue()
        {
            int value = 0;

            foreach(Card card in cards)
            {
                switch(card.Name[0])
                {
                    case 'A':
                        value += 14;
                        break;
                    case 'K':
                        value += 13;
                        break;
                    case 'Q':
                        value += 12;
                        break;
                    case 'J':
                        value += 11;
                        break;
                    default:
                        value += card.Value;
                        break;
                }
            }

            return value;
        }
    }
}

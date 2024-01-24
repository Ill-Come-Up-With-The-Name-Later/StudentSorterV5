namespace StudentSorter.BlackJack.Cards
{
    public class Card
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public Suit CardSuit { get; set; }
        public CardType Type { get; set; }

        /// <summary>
        /// A playing card
        /// </summary>
        /// <param name="name">
        /// 2-10, A, J, K, Q
        /// </param>
        /// <param name="value">
        /// The value of the card
        /// </param>
        /// <param name="suit">
        /// Clubs, Diamonds, Spades, Hearts
        /// </param>
        public Card(string name, int value, Suit suit)
        {
            Name = name;
            Value = value;
            CardSuit = suit;

            switch (Name)
            {
                case "J":
                    Type = CardType.Face;
                    break;
                case "Q":
                    Type = CardType.Face;
                    break;
                case "K":
                    Type = CardType.Face;
                    break;
                case "A":
                    Type = CardType.Ace;
                    break;
                default:
                    Type = CardType.Number;
                    break;
            }

            switch (CardSuit)
            {
                case Suit.Hearts:
                    Name += "♥";
                    break;
                case Suit.Clubs:
                    Name += "♣";
                    break;
                case Suit.Diamonds:
                    Name += "♦";
                    break;
                case Suit.Spades:
                    Name += "♠";
                    break;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

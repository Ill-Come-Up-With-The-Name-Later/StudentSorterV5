using StudentSorter.Debug;

namespace StudentSorter.Gambling.Cards
{
    public class Card
    {
        // All four suits in a standard deck
        public static List<Suit> Suits = new()
        {
            Suit.Hearts,
            Suit.Spades,
            Suit.Clubs,
            Suit.Diamonds,
        };

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

            Type = Name switch
            {
                "J" => CardType.Face,
                "Q" => CardType.Face,
                "K" => CardType.Face,
                "A" => CardType.Ace,
                _ => CardType.Number,
            };

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

        /// <summary>
        /// Finds a card in a list of
        /// cards. Suit and name must match.
        /// </summary>
        /// <param name="name">
        /// The card to find
        /// </param>
        /// <param name="cardList">
        /// The list to search
        /// </param>
        /// <returns>
        /// The index of card
        /// </returns>
        public static int FindCardInList(string name, List<Card> cardList)
        {
            Suit suit = Suit.Clubs;

            suit = name[^1] switch
            {
                '♥' => Suit.Hearts,
                '♣' => Suit.Clubs,
                '♦' => Suit.Diamonds,
                '♠' => Suit.Spades,
            };

            foreach (Card card in cardList)
            {
                if(card.Name.Equals(name) && card.CardSuit == suit) return cardList.IndexOf(card);
            }
            Debugger.Log($"Couldn't find card {name} in list");
            return -1;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

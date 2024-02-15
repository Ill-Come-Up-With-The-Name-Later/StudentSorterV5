using StudentSorter.CardGames.Cards;
using StudentSorter.Debug;
using StudentSorter.Gambling.Cards;

namespace StudentSorter.CardGames.Poker.Player
{
    public class Hand
    {
        public List<Card> Cards = new();
        public PokerPlayer Owner;

        public Card this[int index] { get { return Cards[index]; } set { Cards[index] = value; } }
        public Card this[Index index] { get { return Cards[index.Value]; } set { Cards[index.Value] = value; } }

        /// <summary>
        /// A hand of cards
        /// </summary>
        public Hand()
        {
        }

        /// <summary>
        /// Adds all cards from a list
        /// to this hand
        /// </summary>
        /// <param name="cards">
        /// The cards to add
        /// </param>
        public void AddAll(List<Card> cards)
        {
            cards.ForEach(x => { AddCard(x); });
        }

        /// <summary>
        /// Gets the value of this hand
        /// </summary>
        /// <returns>
        /// The value of the hand
        /// </returns>
        public int GetHandValue()
        {
            int value = 0;

            foreach (Card card in Cards)
            {
                value += card.Name[0] switch
                {
                    'A' => 14,
                    'K' => 13,
                    'Q' => 12,
                    'J' => 11,
                    _ => card.Value,
                };
            }

            return value;
        }

        /// <summary>
        /// Adds a card to this hand
        /// </summary>
        /// <param name="card">
        /// The card to add
        /// </param>
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        /// <summary>
        /// Removes a card from
        /// the hand
        /// </summary>
        /// <param name="card">
        /// The card to remove
        /// </param>
        public void RemoveCard(Card card)
        {
            Cards.Remove(card);
            Debugger.Log($"Removed {card} from {(Owner == null ? "x" : Owner.Name)}'s Hand");
        }

        /// <summary>
        /// Finds the highest value card in
        /// the hand
        /// </summary>
        /// <returns>
        /// The highest value card in the
        /// hand
        /// </returns>
        public Card GetHighestCard()
        {
            List<Card> cards = Cards;
            cards.Sort(new CardComparer());

            return cards[0];
        }
        
        /// <summary>
        /// Gets if removing a card would
        /// affect this hand significantly.
        /// (USE THIS ONLY IF THE HAND HAS MORE
        /// THAN 5 CARDS)
        /// </summary>
        /// <param name="card">
        /// The card to check
        /// </param>
        /// <returns>
        /// If removal of the card affects the hand
        /// </returns>
        public bool RemovalAffectsHand(Card card)
        {
            if (!SpecialHand()) return false;
            Hand clone = new();
            clone.AddAll(Cards);

            clone.RemoveCard(card);

            return clone.SpecialHand();
        }

        /// <summary>
        /// Returns if the suits of all the cards
        /// in the hand match
        /// </summary>
        /// <returns>
        /// True if all cards are of the same
        /// suit, false otherwise
        /// </returns>
        public bool AllCardSuitsMatch()
        {
            Suit suit = Cards[0].CardSuit;

            for(int i = 0; i < 5; i++)
            {
                if(Cards[i].CardSuit != suit) return false;
            }

            return true;
        }

        /// <summary>
        /// Finds if there is an ace
        /// in the hand
        /// </summary>
        /// <returns>
        /// True if an ace is found, false
        /// otherwise
        /// </returns>
        public bool ContainsAce()
        {
            foreach(Card card in Cards)
                if(card.Name.StartsWith('A')) return true;

            return false;
        }

        /// <summary>
        /// Finds if there is a king
        /// in the hand
        /// </summary>
        /// <returns>
        /// True if a king is found, false
        /// otherwise
        /// </returns>
        public bool ContainsKing()
        {
            foreach (Card card in Cards)
                if (card.Name.StartsWith('K')) return true;

            return false;
        }

        /// <summary>
        /// Finds if there is a queen in
        /// the hand
        /// </summary>
        /// <returns>
        /// True if a queen is found, false
        /// otherwise
        /// </returns>
        public bool ContainsQueen()
        {
            foreach (Card card in Cards)
                if (card.Name.StartsWith('Q')) return true;

            return false;
        }

        /// <summary>
        /// Finds if there is a jack in the
        /// hand
        /// </summary>
        /// <returns>
        /// True if a jack is found, false
        /// otherwise
        /// </returns>
        public bool ContainsJack()
        {
            foreach (Card card in Cards)
                if (card.Name.StartsWith('J')) return true;

            return false;
        }

        /// <summary>
        /// Gets the amount of each card in the hand
        /// </summary>
        /// <returns>
        /// A dictionary detailing the amount of
        /// each card in this hand
        /// </returns>
        public Dictionary<string, int> CardAmounts()
        {
            Dictionary<string, int> cardAmounts = new();

            foreach (Card card in Cards)
            {
                if (cardAmounts.ContainsKey(card.Name[..^1]))
                {
                    cardAmounts[card.Name[..^1]]++;
                }
                else
                {
                    cardAmounts[card.Name[..^1]] = 1;
                }
            }

            return cardAmounts;
        }

        /// <summary>
        /// Finds the number of pairs in
        /// the hand
        /// </summary>
        /// <returns>
        /// The number of pairs in the hand
        /// </returns>
        public int NumPairs()
        {
            Dictionary<string, int> cardAmounts = CardAmounts();
            int pairs = 0;

            foreach(string key in cardAmounts.Keys)
            {
                if (cardAmounts[key] == 2)
                    pairs++;
            }

            Debugger.Log($"{(Owner == null ? "x" : Owner.Name)}'s hand contains {pairs} pairs");
            return pairs;
        }

        /// <summary>
        /// Gets the highest value pair
        /// in the hand
        /// </summary>
        /// <returns>
        /// The highest valued pair in the hand
        /// </returns>
        public int HighestPairValue()
        {
            if(!(NumPairs() > 0)) return -1;

            Dictionary<string, int> cardAmounts = CardAmounts();

            List<int> PairVals = new();
            foreach(string key in cardAmounts.Keys)
            {
                if (cardAmounts[key] == 2)
                {
                    PairVals.Add(PokerPlayer.GetCardValue(key));
                    Debugger.Log($"{key} is a pair in {Owner.Name}'s hand ({cardAmounts[key]} occurances)");
                    continue;
                }
                Debugger.Log($"{key} is not in a par in {Owner.Name}'s hand ({cardAmounts[key]} occurances)");
            }

            if (PairVals.Count > 0)
            {
                PairVals.Sort();

                Debugger.Log($"{Owner.Name}: Highest pair value in hand: {PairVals[0]}");
                return PairVals[0];
            }

            Debugger.Log($"{Owner.Name}'s hand has no pairs to compare");
            return -1;
        }

        /// <summary>
        /// Gets the value of a three of 
        /// a kind in the hand if there is one
        /// </summary>
        /// <returns>
        /// The value of the three of a kind in
        /// this hand if there is one, otherwise, -1
        /// </returns>
        public int ThreeOfAKindValue()
        {
            for (int i = 2; i <= 14; i++)
                if (ThreeOfAKind(i)) 
                {
                    Debugger.Log($"{Owner.Name}'s three of a kind value: {i}");
                    return i; 
                }

            return -1;
        }

        /// <summary>
        /// Gets the value of a four
        /// of a kind in this hand if there is
        /// one
        /// </summary>
        /// <returns>
        /// The value of the four of a kind in
        /// the hand if there is one, otherwise, -1
        /// </returns>
        public int FourOfAKindValue()
        {
            for (int i = 2; i <= 14; i++)
                if (FourOfAKind(i)) 
                {
                    Debugger.Log($"{Owner.Name}'s four of a kind value: {i}");
                    return i; 
                }

            return -1;
        }

        /// <summary>
        /// Gets the value of the highest ranked
        /// card
        /// </summary>
        /// <returns>
        /// The value of the highest ranked
        /// card
        /// </returns>
        public int HighestCardValue() => GetHighestCard().Value;

        /// <summary>
        /// Gets the highest unique card value
        /// </summary>
        /// <returns>
        /// The highest value card that doesn't appear
        /// more than once in the hand
        /// </returns>
        public int HighestUniqueCardValue()
        {
            Dictionary<string, int> cardAmounts = CardAmounts();

            int max = -1;
            foreach(string name in cardAmounts.Keys)
            {
                if (cardAmounts[name] > 1) continue;

                if(PokerPlayer.GetCardValue(name) > max) 
                    max = PokerPlayer.GetCardValue(name);
            }

            return max;
        }

        /// <summary>
        /// Finds the number of cards of a
        /// specified rank
        /// </summary>
        /// <param name="rank">
        /// The rank to count for
        /// </param>
        /// <returns>
        /// The number of cards with the specified
        /// rank
        /// </returns>
        public int NumCardsOfRank(int rank)
        {
            int numCards = 0;

            foreach(Card card in Cards)
                if(card.Value == rank) numCards++;

            if(numCards > 0) 
                Debugger.Log($"{numCards} card(s) of rank {rank} in {(Owner == null ? "x" : Owner.Name)}'s hand");
            
            return numCards;
        }

        /// <summary>
        /// Returns if the hand's first 5 cards
        /// are in descending order and go
        /// down in increments of 1.
        /// (greatest -> least)
        /// </summary>
        /// <returns>
        /// If the cards are in descending order
        /// </returns>
        public bool InDescendingOrder()
        {
            Cards.Sort(new CardComparer());
            int prevVal = int.MaxValue;

            for(int i = 0; i < 5; i++)
            {
                if (prevVal - 1 == Cards[i].Value) 
                { 
                    prevVal = Cards[i].Value; 
                    i++; 
                }
                else return false;
            }

            return true;
        }

        /// <summary>
        /// Finds if the hand contains a card (no suit)
        /// </summary>
        /// <param name="startName">
        /// The first characters (e.g. 10, 9, 8)
        /// </param>
        /// <returns>
        /// If the card is found
        /// </returns>
        public bool ContainsCard(string startName)
        {
            foreach(Card card in Cards)
                if(card.Name.StartsWith(startName)) return true;

            return false;
        }

        /// <summary>
        /// Returns if the hand contains a card
        /// and the suit matches
        /// </summary>
        /// <param name="startName">
        /// Card name without the suit
        /// </param>
        /// <param name="suit">
        /// The suit to match
        /// </param>
        /// <returns>
        /// True if the card name and suit match, false
        /// otherwise
        /// </returns>
        public bool ContainsCard(string startName, Suit suit)
        {
            foreach (Card card in Cards)
                if (card.Name.StartsWith(startName) && card.CardSuit == suit) return true;

            return false;
        }

        /// <summary>
        /// Gets if this hand is a special hand
        /// that has something that counts
        /// </summary>
        /// <returns>
        /// If the hand is speical
        /// </returns>
        public bool SpecialHand()
        {
            for(int i = 1; i <= 14; i++)
            {
                if (ThreeOfAKind(i) || FourOfAKind(i) || FullHouse(i)) return true;
            }
            return RoyalFlush() || StraightFlush() || Flush() || Straight() || TwoPairs() || OnePair();
        }

        /// <summary>
        /// Gets if a list of cards would be a special
        /// hand
        /// </summary>
        /// <param name="cards">
        /// The list to check
        /// </param>
        /// <returns>
        /// If the list is a special hand
        /// </returns>
        public static bool SpecialHand(List<Card> cards, PokerPlayer player)
        {
            Hand hand = new()
            {
                Owner = player
            };

            foreach (Card card in cards) 
                hand.AddCard(card);

            return hand.SpecialHand();
        }

        /// <summary>
        /// Returns if the hand is a royal
        /// flush
        /// </summary>
        /// <returns>
        /// True if the hand is a royal flush, false
        /// otherwise
        /// </returns>
        public bool RoyalFlush()
        {
            return ContainsAce() && ContainsJack() && ContainsKing() 
                && ContainsKing() && ContainsCard("10") && AllCardSuitsMatch();
        }

        /// <summary>
        /// Finds if the hand is a straight flush
        /// </summary>
        /// <returns>
        /// True if the hand is a straight flush, false
        /// otherwise
        /// </returns>
        public bool StraightFlush()
        {
            return InDescendingOrder() && AllCardSuitsMatch();
        }

        /// <summary>
        /// Determins if this hand has a flush
        /// </summary>
        /// <returns>
        /// If the cards in the hand
        /// make a flush
        /// </returns>
        public bool Flush()
        {
            return AllCardSuitsMatch();
        }

        /// <summary>
        /// Returns if the hand is a four of
        /// a kind with four cards of a specific
        /// rank
        /// </summary>
        /// <param name="rank">
        /// The rank to look for
        /// </param>
        /// <returns>
        /// If the hand has four cards of
        /// the desired rank
        /// </returns>
        public bool FourOfAKind(int rank)
        {
            return NumCardsOfRank(rank) == 4;
        }

        /// <summary>
        /// Finds if the hand is a three of a kind
        /// </summary>
        /// <param name="rank">
        /// The rank to search for
        /// </param>
        /// <returns>
        /// If there are three cards of the same
        /// rank in the hand
        /// </returns>
        public bool ThreeOfAKind(int rank)
        {
            return NumCardsOfRank(rank) == 3;
        }

        /// <summary>
        /// Finds if the hand is a full house
        /// </summary>
        /// <param name="rank">
        /// The rank to search for a three of a kind
        /// for
        /// </param>
        /// <returns>
        /// If the hand is a three of a kind and has
        /// a pair
        /// </returns>
        public bool FullHouse(int rank)
        {
            return ThreeOfAKind(rank) && NumPairs() == 1;
        }

        /// <summary>
        /// Finds if the hand is a straight
        /// </summary>
        /// <returns>
        /// If the hand is a straight
        /// </returns>
        public bool Straight()
        {
            return InDescendingOrder();
        }

        /// <summary>
        /// Finds if the hand has two pairs
        /// </summary>
        /// <returns>
        /// If the hand has two pairs in it
        /// </returns>
        public bool TwoPairs()
        {
            return NumPairs() == 2;
        }

        /// <summary>
        /// FInds if the hand has only one
        /// pair in it
        /// </summary>
        /// <returns>
        /// If the hand has one pair
        /// </returns>
        public bool OnePair()
        {
            return NumPairs() == 1;
        }
    }
}

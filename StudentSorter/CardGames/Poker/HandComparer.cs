﻿using StudentSorter.CardGames.Cards;
using StudentSorter.CardGames.Poker.Player;

namespace StudentSorter.CardGames.Poker
{
    public class HandComparer : IComparer<Hand>
    {
        /// <summary>
        /// Compares two hand
        /// </summary>
        /// <param name="x"> 
        /// A hand
        /// </param>
        /// <param name="y"> 
        /// A hand
        /// </param>
        /// <returns>
        /// If one hand goes before, after, or the same as
        /// another
        /// </returns>
        public int Compare(Hand? x, Hand? y)
        {
            if (x == null || y == null) return 0;

            // Royal flush
            if (x.RoyalFlush() && !y.RoyalFlush()) return -1;
            else if (x.RoyalFlush() && y.RoyalFlush())
            {
                if (x.HighestUniqueCardValue() < y.HighestUniqueCardValue()) return 1;
                else if (x.HighestUniqueCardValue() > y.HighestUniqueCardValue()) return -1;
                else if (x.HighestUniqueCardValue() == y.HighestUniqueCardValue()) return 0;
            }
            else if (!x.RoyalFlush() && y.RoyalFlush()) return 1;

            // Straight flush
            if (x.StraightFlush() && !y.StraightFlush()) return -1;
            else if (x.StraightFlush() && y.StraightFlush())
            {
                if (x.HighestUniqueCardValue() < y.HighestUniqueCardValue()) return 1;
                else if (x.HighestUniqueCardValue() > y.HighestUniqueCardValue()) return -1;
                else if (x.HighestUniqueCardValue() == y.HighestUniqueCardValue()) return 0;
            }
            else if (!x.StraightFlush() && y.StraightFlush()) return 1;

            // Four of a kind
            for (int i = 2; i <= 14; i++)
            {
                if (x.FourOfAKind(i) && !y.FourOfAKind(i)) return -1;
                else if (x.FourOfAKind(i) && y.FourOfAKind(i))
                {
                    if (x.FourOfAKindValue() < y.FourOfAKindValue()) return 1;
                    else if (x.FourOfAKindValue() > y.FourOfAKindValue()) return -1;
                    else if (x.FourOfAKindValue() == y.FourOfAKindValue())
                        if (x.HighestUniqueCardValue() < y.HighestUniqueCardValue()) return 1;
                        else if (x.HighestUniqueCardValue() > y.HighestUniqueCardValue()) return -1;
                        else if (x.HighestUniqueCardValue() == y.HighestUniqueCardValue()) return 0;
                }
                else if (!x.FourOfAKind(i) && y.FourOfAKind(i)) return 1;
            }

            // Full House
            for (int i = 2; i <= 14; i++)
            {
                if (x.FullHouse(i) && !y.FullHouse(i)) return -1;
                else if (x.FullHouse(i) && y.FullHouse(i))
                {
                    if (x.HighestUniqueCardValue() < y.HighestUniqueCardValue()) return 1;
                    else if (x.HighestUniqueCardValue() > y.HighestUniqueCardValue()) return -1;
                    else if (x.HighestUniqueCardValue() == y.HighestUniqueCardValue()) return 0;
                }
                else if (!x.FullHouse(i) && y.FullHouse(i)) return 1;
            }

            // Flush
            if (x.Flush() && !x.Flush()) return -1;
            else if (x.Flush() && y.Flush())
            {
                if (x.HighestUniqueCardValue() < y.HighestUniqueCardValue()) return 1;
                else if (x.HighestUniqueCardValue() > y.HighestUniqueCardValue()) return -1;
                else if (x.HighestUniqueCardValue() == y.HighestUniqueCardValue()) return 0;
            }
            else if (!x.Flush() && y.Flush()) return 1;

            // Straight
            if (x.Straight() && !y.Straight()) return -1;
            else if (x.Straight() && y.Straight())
            {
                if (x.HighestUniqueCardValue() < y.HighestUniqueCardValue()) return 1;
                else if (x.HighestUniqueCardValue() > y.HighestUniqueCardValue()) return -1;
                else if (x.HighestUniqueCardValue() == y.HighestUniqueCardValue()) return 0;
            }
            else if (!x.Straight() && y.Straight()) return 1;

            // Three of a Kind
            for (int i = 2; i <= 14; i++)
            {
                if (x.ThreeOfAKind(i) && !y.ThreeOfAKind(i)) return -1;
                else if (x.ThreeOfAKind(i) && y.ThreeOfAKind(i))
                {
                    if (x.ThreeOfAKindValue() < y.ThreeOfAKindValue()) return 1;
                    else if (x.ThreeOfAKindValue() > y.ThreeOfAKindValue()) return -1;
                    else if (x.ThreeOfAKindValue() == y.ThreeOfAKindValue())
                        if (x.HighestUniqueCardValue() < y.HighestUniqueCardValue()) return 1;
                        else if (x.HighestUniqueCardValue() > y.HighestUniqueCardValue()) return -1;
                        else if (x.HighestUniqueCardValue() == y.HighestUniqueCardValue()) return 0;
                }
                else if (!x.ThreeOfAKind(i) && y.ThreeOfAKind(i)) return 1;
            }

            // Two pairs
            if (x.TwoPairs() && !y.TwoPairs()) return -1;
            else if (x.TwoPairs() && y.TwoPairs())
            {
                if (x.HighestPairValue() < y.HighestPairValue()) return 1;
                else if (x.HighestPairValue() > y.HighestPairValue()) return -1;
                else if (x.HighestPairValue() == y.HighestPairValue())
                    if (x.HighestUniqueCardValue() < y.HighestUniqueCardValue()) return 1;
                    else if (x.HighestUniqueCardValue() > y.HighestUniqueCardValue()) return -1;
                    else if (x.HighestUniqueCardValue() == y.HighestUniqueCardValue()) return 0;
            }
            else if (!x.TwoPairs() && y.TwoPairs()) return 1;

            // One Pair
            if (x.OnePair() && !y.OnePair()) return -1;
            else if (x.OnePair() && y.OnePair())
            {
                if (x.HighestPairValue() < y.HighestPairValue()) return 1;
                else if (x.HighestPairValue() > y.HighestPairValue()) return -1;
                else if (x.HighestPairValue() == y.HighestPairValue())
                    if (x.HighestUniqueCardValue() < y.HighestUniqueCardValue()) return 1;
                    else if (x.HighestUniqueCardValue() > y.HighestUniqueCardValue()) return -1;
                    else if (x.HighestUniqueCardValue() == y.HighestUniqueCardValue()) return 0;
            }
            else if (!x.OnePair() && y.OnePair()) return 1;

            Card xCard = x.GetHighestCard();
            Card yCard = y.GetHighestCard();

            if (xCard.Value > yCard.Value) return -1;
            else if (yCard.Value > xCard.Value) return 1;
            else if (xCard.Value == yCard.Value) return 0;

            return 0;
        }
    }
}

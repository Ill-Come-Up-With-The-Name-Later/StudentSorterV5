﻿using StudentSorter.Debug;
using StudentSorter.Gambling.Cards;

namespace StudentSorter.CardGames.Poker.Player
{
    public class Hand
    {
        public List<Card> Cards = new();

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

            foreach (Card card in Cards)
            {
                switch (card.Name[0])
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

            foreach (Card card in Cards)
                if(card.CardSuit != suit) return false;

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
        /// Finds the number of pairs in
        /// the hand
        /// </summary>
        /// <returns>
        /// The number of pairs in the hand
        /// </returns>
        public int NumPairs()
        {
            Dictionary<char, int> cardAmounts = new();
            int pairs = 0;

            foreach(Card card in Cards)
            {
                if (cardAmounts.ContainsKey(card.Name[0]))
                {
                    cardAmounts[card.Name[0]]++;
                } 
                else
                {
                    cardAmounts[card.Name[0]] = 1;
                }
            }

            foreach(char key in cardAmounts.Keys)
            {
                if (cardAmounts[key] >= 2)
                    pairs++;
            }

            Debugger.Log($"Hand contains {pairs} pairs");
            return pairs;
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

            return numCards;
        }

        /// <summary>
        /// Returns if the hand's cards
        /// are in descending order
        /// (greatest -> least)
        /// </summary>
        /// <returns>
        /// If the cards are in descending order
        /// </returns>
        public bool InDescendingOrder()
        {
            int prevVal = int.MaxValue;

            foreach(Card card in Cards)
            {
                if(card.Value < prevVal) prevVal = card.Value;
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
    }
}
using StudentSorter.CardGames.Cards;
using StudentSorter.CardGames.Poker.Player;
using StudentSorter.Debug;

namespace StudentSorter.CardGames.Poker.FiveCardDraw
{
    public class DrawManager
    {
        public List<PokerPlayer> Players = new();
        public List<string> PlayerNames = new()
        {
            "Sgt. Pepper", // Sgt. Pepper's Lonely Hearts Club Band (The Beatles)
            "Jude", // Hey Jude (The Beatles)
            "Elanor Rigby", // Elanor Rigby (The Beatles)
            "Rose", // Everything's Coming Up Rose's (Roger Miller)
            "Mr. Mustard", // Mean Mr. Mustard (The Beatles)
            "Desmond Jones", // O-bla-di, O-bla-da (The Beatles)
            "Molly Jones", // O-bla-di, O-bla-da (The Beatles)
            "Billy Shears", // With a Little Help From My Friends (The Beatles)
            "Lucy", // Lucy in the Sky With Diamonds (The Beatles)
            "Prudence", // Dear Prudence (The Beatles)
            "Bobby McGee", // Me and Bobby McGee (Roger Miller)
            "Maxwell Edison", // Maxwell's Silver Hammer (The Beatles)
            "Joan", // Maxwell's Silver Hammer (The Beatles)
            "P.C. 31", // Maxwell's Silver Hammer (The Beatles)
            "Rose", // Maxwell's Silver Hammer (The Beatles)
            "Valerie", // Maxwell's Silver Hammer (The Beatles)
            "Polythene Pam", // Polythene Pam (The Beatles)
            "Billy Bayou", // Billy Bayou (Roger Miller)
            "Vera", // When I'm Sixty-Four (The Beatles)
            "Chuck", // When I'm Sixty-Four (The Beatles)
            "Dave", // When I'm Sixty-Four (The Beatles)
            "Maggie Mae", // Maggie Mae (The Beatles)
            "Loretta Martin", // Get Back (The Beatles)
            "Father McKenzie", // Elanor Rigby (The Beatles)
            "Mr. Kite", // Being For the Benefit of Mr. Kite! (The Beatles)
        };

        public List<Card> Deck = new();

        public DrawManager()
        {
        }

        /// <summary>
        /// Sets up Poker (5-Card Draw)
        /// </summary>
        public void SetupGame()
        {
            // Add player
            PokerPlayer player = new();
            Players.Add(player);

            // Add bots
            for (int i = 0; i < 5; i++)
            {
                string name = PlayerNames[new Random().Next(0, PlayerNames.Count)];

                while (NameDuplicate(name))
                    name = PlayerNames[new Random().Next(0, PlayerNames.Count)];

                PokerPlayer botPlayer = new(name);

                Players.Add(botPlayer);
                Debugger.Log($"Added {botPlayer.Name} to the table");
            }

            // Set up the deck
            foreach (Suit suit in Card.Suits)
            {
                for (int j = 2; j <= 10; j++)
                {
                    Card card = new($"{j}", j, suit);
                    Deck.Add(card);
                }

                Card ace = new("A", 14, suit);
                Deck.Add(ace);

                Card jack = new("J", 11, suit);
                Deck.Add(jack);

                Card king = new("K", 13, suit);
                Deck.Add(king);

                Card queen = new("Q", 12, suit);
                Deck.Add(queen);
            }

            // Shuffles the deck
            Deck.Sort(new CardShuffler());

            Debugger.Log($"Deck Size: {Deck.Count}/52");
            Debugger.Log("Setup Poker deck");

            // Deal cards
            foreach (PokerPlayer pokerPlayer in Players)
            {
                if (pokerPlayer.PlayerHand.Cards.Count > 0) continue;
                for(int i = 0; i < 5; i++)
                    AddCard(pokerPlayer);
            }

            Debugger.Log("Setup Poker (5-Card Draw)");

            // Show if player has a special hand
            foreach(PokerPlayer pokerPlayer in Players)
            {
                Debugger.Log($"{pokerPlayer.Name} has royal flush: {pokerPlayer.PlayerHand.RoyalFlush()}");
                Debugger.Log($"{pokerPlayer.Name} has straight flush: {pokerPlayer.PlayerHand.StraightFlush()}");

                for(int i = 2; i <= 14; i++)
                    if(pokerPlayer.PlayerHand.FourOfAKind(i))
                        Debugger.Log($"{pokerPlayer.Name} has four of a kind: {pokerPlayer.PlayerHand.FourOfAKind(i)}");

                for (int i = 2; i <= 14; i++)
                    if (pokerPlayer.PlayerHand.FullHouse(i))
                        Debugger.Log($"{pokerPlayer.Name} has full house: {pokerPlayer.PlayerHand.FullHouse(i)}");

                Debugger.Log($"{pokerPlayer.Name} has flush: {pokerPlayer.PlayerHand.Flush()}");
                Debugger.Log($"{pokerPlayer.Name} has straight: {pokerPlayer.PlayerHand.Straight()}");

                for (int i = 2; i <= 14; i++)
                    if (pokerPlayer.PlayerHand.ThreeOfAKind(i))
                        Debugger.Log($"{pokerPlayer.Name} has full house: {pokerPlayer.PlayerHand.ThreeOfAKind(i)}");

                Debugger.Log($"{pokerPlayer.Name} has two pairs: {pokerPlayer.PlayerHand.TwoPairs()}");
                Debugger.Log($"{pokerPlayer.Name} has pair: {pokerPlayer.PlayerHand.OnePair()}");
            }
        }

        /// <summary>
        /// Adds a card to a player's hand
        /// </summary>
        /// <param name="pokerPlayer">
        /// The player to give a card to
        /// </param>
        public void AddCard(PokerPlayer pokerPlayer)
        {
            Card card = Deck[0];
            pokerPlayer.AddCard(card);
            Deck.Remove(card);

            Debugger.Log($"Gave {card} to {pokerPlayer.Name}");
        }

        /// <summary>
        /// Checks if a name is a duplicate
        /// </summary>
        /// <param name="name">
        /// The name to check
        /// </param>
        /// <returns>
        /// If the name is a duplicate
        /// </returns>
        public bool NameDuplicate(string name)
        {
            int occurences = 0;

            foreach (PokerPlayer pokerPlayer in Players)
                if (pokerPlayer.Name.Equals(name)) occurences++;

            return occurences > 0;
        }

        /// <summary>
        /// Allows the bots to discard
        /// their cards
        /// </summary>
        public void BotDiscard()
        {
            for(int i = 1; i < Players.Count; i++)
            {
                PokerPlayer player = Players[i];

                if (player.Folded) continue;

                if(player.PlayerHand.SpecialHand()) continue; // Don't risk a possibly decent hand

                if(player.PlayerHand.GetHandValue() < 45)
                {
                    if(new Random().Next(0, 4) == 1)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            player.RemoveCard(player.PlayerHand.Cards[j]);
                            AddCard(player);
                        }
                    }
                }

                player.PlayerHand.Cards.Sort(new CardComparer());
            }
        }

        /// <summary>
        /// Gives a player a three of a kind
        /// </summary>
        /// <param name="player">
        /// The player to give the cards to 
        /// </param>
        public void GiveThreeOfAKind(PokerPlayer player)
        {
            player.PlayerHand.Cards.Clear();

            Card card1 = new("A", 14, Suit.Clubs);
            Card card2 = new("A", 14, Suit.Hearts);
            Card card3 = new("A", 14, Suit.Spades);

            player.AddCard(card1);
            player.AddCard(card2);
            player.AddCard(card3);
            AddCard(player);
            AddCard(player);

            Debugger.Log($"Gave {player.Name} a three of a kind");
        }

        /// <summary>
        /// Gives a player a four of a kind
        /// </summary>
        /// <param name="player">
        /// The player to give the cards to 
        /// </param>
        public void GiveFourOfAKind(PokerPlayer player)
        {
            player.PlayerHand.Cards.Clear();

            Card card1 = new("A", 14, Suit.Clubs);
            Card card2 = new("A", 14, Suit.Hearts);
            Card card3 = new("A", 14, Suit.Spades);
            Card card4 = new("A", 14, Suit.Diamonds);

            player.AddCard(card1);
            player.AddCard(card2);
            player.AddCard(card3);
            player.AddCard(card4);
            AddCard(player);

            Debugger.Log($"Gave {player.Name} a four of a kind");
        }

        /// <summary>
        /// Gives a player a royal flush
        /// </summary>
        /// <param name="player">
        /// The player to give the cards to 
        /// </param>
        public void GiveRoyalFlush(PokerPlayer player)
        {
            player.PlayerHand.Cards.Clear();

            Card card1 = new("A", 14, Suit.Clubs);
            Card card2 = new("K", 13, Suit.Clubs);
            Card card3 = new("Q", 12, Suit.Clubs);
            Card card4 = new("J", 11, Suit.Clubs);
            Card card5 = new("10", 10, Suit.Clubs);

            player.AddCard(card1);
            player.AddCard(card2);
            player.AddCard(card3);
            player.AddCard(card4);
            player.AddCard(card5);

            Debugger.Log($"Gave {player.Name} a royal flush");
        }

        /// <summary>
        /// Gives a player a full house
        /// </summary>
        /// <param name="player">
        /// The player to give the cards to 
        /// </param>
        public void GiveFullHouse(PokerPlayer player)
        {
            player.PlayerHand.Cards.Clear();

            Card card1 = new("A", 14, Suit.Clubs);
            Card card2 = new("A", 14, Suit.Clubs);
            Card card3 = new("A", 14, Suit.Clubs);
            Card card4 = new("K", 13, Suit.Clubs);
            Card card5 = new("K", 13, Suit.Clubs);

            player.AddCard(card1);
            player.AddCard(card2);
            player.AddCard(card3);
            player.AddCard(card4);
            player.AddCard(card5);

            Debugger.Log($"Gave {player.Name} a full house");
        }

        /// <summary>
        /// Gives a player a straight
        /// </summary>
        /// <param name="player">
        /// The player to give the cards to 
        /// </param>
        public void GiveStraight(PokerPlayer player)
        {
            player.PlayerHand.Cards.Clear();

            Card card1 = new("A", 14, Suit.Spades);
            Card card2 = new("K", 13, Suit.Clubs);
            Card card3 = new("Q", 12, Suit.Diamonds);
            Card card4 = new("J", 11, Suit.Clubs);
            Card card5 = new("10", 10, Suit.Hearts);

            player.AddCard(card1);
            player.AddCard(card2);
            player.AddCard(card3);
            player.AddCard(card4);
            player.AddCard(card5);

            Debugger.Log($"Gave {player.Name} a straight");
        }

        /// <summary>
        /// Gives a player a straight
        /// </summary>
        /// <param name="player">
        /// The player to give the cards to 
        /// </param>
        public void GiveStraightFlush(PokerPlayer player)
        {
            player.PlayerHand.Cards.Clear();

            Card card1 = new("K", 13, Suit.Clubs);
            Card card2 = new("Q", 12, Suit.Clubs);
            Card card3 = new("J", 11, Suit.Clubs);
            Card card4 = new("10", 10, Suit.Clubs);
            Card card5 = new("9", 9, Suit.Clubs);

            player.AddCard(card1);
            player.AddCard(card2);
            player.AddCard(card3);
            player.AddCard(card4);
            player.AddCard(card5);

            Debugger.Log($"Gave {player.Name} a straight flush");
        }

        /// <summary>
        /// Gives a player two pairs
        /// </summary>
        /// <param name="player">
        /// The player to give the cards to 
        /// </param>
        public void GiveTwoPairs(PokerPlayer player)
        {
            player.PlayerHand.Cards.Clear();

            Card card1 = new("A", 14, Suit.Clubs);
            Card card2 = new("A", 14, Suit.Spades);
            Card card3 = new("K", 13, Suit.Clubs);
            Card card4 = new("K", 13, Suit.Diamonds);
            AddCard(player);

            player.AddCard(card1);
            player.AddCard(card2);
            player.AddCard(card3);
            player.AddCard(card4);

            Debugger.Log($"Gave {player.Name} two pairs");
        }

        /// <summary>
        /// Gives a player one pair
        /// </summary>
        /// <param name="player">
        /// The player to give the cards to 
        /// </param>
        public void GiveOnePair(PokerPlayer player)
        {
            player.PlayerHand.Cards.Clear();

            Card card1 = new("A", 14, Suit.Clubs);
            Card card2 = new("A", 14, Suit.Spades);
            AddCard(player);
            AddCard(player);
            AddCard(player);

            player.AddCard(card1);
            player.AddCard(card2);

            Debugger.Log($"Gave {player.Name} one pair");
        }

        /// <summary>
        /// Gives a player a flush
        /// </summary>
        /// <param name="player">
        /// The player to give the cards to
        /// </param>
        public void GiveFlush(PokerPlayer player)
        {
            player.PlayerHand.Cards.Clear();

            Card card1 = new("A", 14, Suit.Clubs);
            Card card2 = new("K", 13, Suit.Clubs);
            Card card3 = new("Q", 12, Suit.Clubs);
            Card card4 = new("J", 11, Suit.Clubs);
            Card card5 = new("9", 9, Suit.Clubs);

            player.AddCard(card1);
            player.AddCard(card2);
            player.AddCard(card3);
            player.AddCard(card4);
            player.AddCard(card5);

            Debugger.Log($"Gave {player.Name} a flush");
        }
    }
}

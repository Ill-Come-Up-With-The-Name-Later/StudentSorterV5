﻿using StudentSorter.CardGames.Cards;
using StudentSorter.CardGames.Poker.Player;
using StudentSorter.Debug;

namespace StudentSorter.CardGames.Poker.Holdem
{
    public class HoldemManager
    {
        public List<PokerPlayer> Players = new();
        public List<string> PlayerNames = new()
        {
            "James Bond",
            "Vesper Lynd",
            "Le Chiffre",
            "Rene Mathis",
            "M",
            "Villiers",
            "Steven Obanno",
            "Alex Dimitrios",
            "Valenka",
            "Solange Dimitrios",
            "Felix Leiter",
            "Carlos",
            "Mollaka"
        };

        public List<Card> CommunityCards = new();
        public List<Card> Deck = new();

        public PokerPlayer Dealer = new();
        public PokerPlayer BigBlind = new();
        public PokerPlayer SmallBlind = new();

        public int BetRound { get; set; }
        public int Pot { get; set; }
        public int MinBet { get; set; }

        public HoldemManager()
        {
            Pot = 0;
            BetRound = 1;
            MinBet = 0;
        }

        /// <summary>
        /// Sets up the game
        /// </summary>
        public void SetupGame()
        {
            PokerPlayer player = new();
            Players.Add(player);

            for (int i = 0; i < 3; i++)
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

            // Deal first card to players, pick dealer, small blind, and big blind
            foreach (PokerPlayer pokerPlayer in Players)
            {
                AddCard(pokerPlayer);
            }

            List<PokerPlayer> sortedPlayers = new(Players);
            sortedPlayers.Sort(new FirstCardComparer());

            Dealer = sortedPlayers[0];
            sortedPlayers[0].Dealer = true;

            SmallBlind = LeftOf(Dealer);
            SmallBlind.SmallBlind = true;

            BigBlind = LeftOf(SmallBlind);
            BigBlind.BigBlind = true;

            Debugger.Log("Dealer, Big Blind, and Small Blind chosen");

            // Deal second card to players
            foreach (PokerPlayer pokerPlayer in Players)
            {
                AddCard(pokerPlayer);
            }

            Debugger.Log("Two cards have been dealt to all players");
            Debugger.Log("Set up Poker (Texas Hold'em)");
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
        /// Gets the player to the left of a player
        /// </summary>
        /// <param name="pokerPlayer">
        /// The player to start at
        /// </param>
        /// <returns>
        /// The player to the left
        /// </returns>
        public PokerPlayer LeftOf(PokerPlayer pokerPlayer)
        {
            if (Players.IndexOf(pokerPlayer) == 0) return Players[^1];
            if (Players.IndexOf(pokerPlayer) == Players.Count - 1) return Players[0];
            return Players[Players.IndexOf(pokerPlayer) - 1];
        }

        /// <summary>
        /// Plays the first turn
        /// </summary>
        public void FirstTurn()
        {
            BigBlind.Bet = 100;
            SmallBlind.Bet = 50;

            BettingRound(BetRound);

            for (int i = 0; i < 3; i++)
            {
                Card card = Deck[0];
                CommunityCards.Add(card);
                Deck.Remove(card);

                Debugger.Log($"Added {card} to the community cards");
            }

            MinBet = BigBlind.Bet;
        }

        /// <summary>
        /// Play a betting round
        /// </summary>
        /// <param name="bettingRound">
        /// The current round
        /// </param>
        public void BettingRound(int bettingRound)
        {
            // Everyone bets or folds
            foreach (PokerPlayer player in Players)
            {
                if (player.Folded) continue;
                if (player.Equals("Player")) continue;

                if (bettingRound == 1 && (player.BigBlind || player.SmallBlind)) continue;

                int action = new Random().Next(0, 3);
                int playerIndex = new Random().Next(0, Players.Count);

                // Fold on low hand
                if (player.PlayerHand.GetHandValue() < 12)
                {
                    if (new Random().Next(0, 8) == 2)
                    {
                        player.Fold();
                        continue;
                    }
                }

                if (bettingRound == 1)
                {
                    if (action == 0) player.SetBet(player.Bet + BigBlind.Bet, this); // Match Big Blind
                    if (action == 1) player.SetBet(player.Bet + BigBlind.Bet + new Random().Next(5, 51), this); // Bet higher than Big Blind
                    if (action == 2) player.SetBet(player.Bet + Players[playerIndex].Bet > 0 ? player.Bet + Players[playerIndex].Bet
                        : player.Bet + BigBlind.Bet, this);
                }
                else
                {
                    if (action == 0) continue; // Don't make an additional bet
                    if (action == 1) player.SetBet(player.Bet + BigBlind.Bet + new Random().Next(5, 51), this); // Bet higher than Big Blind
                    if (action == 2) player.SetBet(Players[playerIndex].Bet > 0 ? player.Bet + Players[playerIndex].Bet
                        : player.Bet + BigBlind.Bet, this);
                }
            }

            if (BetRound > 1)
            {
                Card card = Deck[0];
                CommunityCards.Add(card);
                Deck.Remove(card);

                Debugger.Log($"Added {card} to the community cards");
            }

            BetRound++;
            Deck.Remove(Deck[0]);
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
    }
}

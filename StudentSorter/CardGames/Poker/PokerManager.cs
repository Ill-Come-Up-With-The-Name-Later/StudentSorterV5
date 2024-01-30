using StudentSorter.CardGames.Cards;
using StudentSorter.CardGames.Poker.Player;
using StudentSorter.Debug;
using StudentSorter.Gambling.Cards;

namespace StudentSorter.CardGames.Poker
{
    public class PokerManager
    {
        public List<PokerPlayer> Players = new();
        public List<string> PlayerNames = new()
        {
            "Sgt. Pepper",
            "Jude",
            "Elanor Rigby",
            "Rose",
            "Mr. Mustard",
            "Desmond Jones",
            "Molly Jones",
            "Charlie Sheen",
            "Lucy",
            "Prudence",
            "Bobby McGee"
        };

        public List<Card> CommunityCards = new();
        public List<Card> Deck = new();

        public PokerPlayer Dealer = new();
        public PokerPlayer BigBlind = new();
        public PokerPlayer SmallBlind = new();

        public int BetRound { get; set; }
        public int Pot {  get; set; }

        public PokerManager() 
        {
            Pot = 0;
            BetRound = 1;
        }

        /// <summary>
        /// Sets up the game
        /// </summary>
        public void SetupGame()
        {
            PokerPlayer player = new();
            Players.Add(player);

            for(int i = 0; i < 3; i++)
            {
                string name = PlayerNames[new Random().Next(0, PlayerNames.Count)];
                PokerPlayer botPlayer = new(name);

                Players.Add(botPlayer);
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

                Card jack = new("J", 10, suit);
                Deck.Add(jack);

                Card king = new("K", 10, suit);
                Deck.Add(king);

                Card queen = new("Q", 10, suit);
                Deck.Add(queen);
            }

            // Shuffles the deck
            Deck.Sort(new CardComparer());

            Debugger.Log($"Deck Size: {Deck.Count}/52");
            Debugger.Log("Setup Poker deck");

            // Deal first card to players, pick dealer, small blind, and big blind
            foreach(PokerPlayer pokerPlayer in Players)
            {
                Card card = Deck[0];
                pokerPlayer.PlayerHand.AddCard(card);
                Deck.Remove(card);

                Debugger.Log($"Gave {card} to {pokerPlayer.Name}");
            }

            List<PokerPlayer> sortedPlayers = new(Players);
            sortedPlayers.Sort(new PokerPlayerComparer());

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
                Card card = Deck[0];
                pokerPlayer.PlayerHand.AddCard(card);
                Deck.Remove(card);

                Debugger.Log($"Gave {card} to {pokerPlayer.Name}");
            }

            Debugger.Log("Two cards have been dealt to all players");
            Debugger.Log("Set up Poker (Texas Hold'em");
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
            if(Players.IndexOf(pokerPlayer) == Players.Count - 1) return Players[^1];
            return Players[Players.IndexOf(pokerPlayer) - 1];
        }

        /// <summary>
        /// Plays the first turn
        /// </summary>
        public void FirstTurn()
        {
            BigBlind.Bet = BigBlind.PlayerHand.GetHandValue() + new Random().Next(5, 51);
            
            // Everyone bets or folds
            foreach(PokerPlayer player in Players)
            {
                if (player.Folded) continue;
                if(player.Name.Equals("Player")) continue;
                if (player.BigBlind) continue;

                int action = new Random().Next(0, 3);
                int playerIndex = new Random().Next(0, Players.Count);
                
                // Fold on low hand
                if(player.PlayerHand.GetHandValue() < 20)
                {
                    if(new Random().Next(0, 3) == 2)
                    {
                        player.Fold();
                        continue;
                    }
                }

                if(action == 0) player.SetBet(BigBlind.Bet, this); // Match Big Blind
                if(action == 1) player.SetBet(BigBlind.Bet + new Random().Next(5, 51), this); // Bet higher than Big Blind
                if(action == 2) player.SetBet(Players[playerIndex].Bet > 0 ? Players[playerIndex].Bet : BigBlind.Bet, this);

                Deck.Remove(Deck[0]);
                BetRound++;

                for(int i = 0; i < 3; i++)
                {
                    Card card = Deck[0];
                    CommunityCards.Add(card);
                    Deck.Remove(card);

                    Debugger.Log($"Added {card} to the community cards");
                }
            }
        }
    }
}

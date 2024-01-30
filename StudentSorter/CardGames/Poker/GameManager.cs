using StudentSorter.CardGames.Cards;
using StudentSorter.CardGames.Poker.Player;
using StudentSorter.Debug;
using StudentSorter.Gambling.Cards;

namespace StudentSorter.CardGames.Poker
{
    public class GameManager
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

        public GameManager() { }

        /// <summary>
        /// Sets up the game
        /// </summary>
        public void SetupGame()
        {
            PokerPlayer player = new();
            Players.Add(player);

            for(int i = 0; i < 4; i++)
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
            Debugger.Log("Setup Poker.");

            // Deal first card to players, pick dealer, small blind, and big blind
            foreach(PokerPlayer pokerPlayer in Players)
            {
                Card card = Deck[0];
                pokerPlayer.PlayerHand.AddCard(card);
                Deck.Remove(card);
            }
        }
    }
}

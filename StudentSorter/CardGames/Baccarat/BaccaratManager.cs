using StudentSorter.CardGames.Baccarat.Player;
using StudentSorter.CardGames.Cards;
using StudentSorter.Debug;
using StudentSorter.Gambling.Cards;

namespace StudentSorter.CardGames.Baccarat
{
    public class BaccaratManager
    {
        public BaccaratPlayer Player1 { get; set; }
        public BaccaratPlayer Player2 { get; set; }

        public List<Card> Deck = new();

        /// <summary>
        /// Manager for Baccarat
        /// 
        /// The player will be player1
        /// </summary>
        /// <param name="player1">
        /// A player
        /// </param>
        /// <param name="player2">
        /// A player
        /// </param>
        public BaccaratManager(BaccaratPlayer player1, BaccaratPlayer player2) 
        {
            Player1 = player1;
            Player2 = player2;
        }

        /// <summary>
        /// Sets up Baccarat
        /// </summary>
        public void SetupGame()
        {
            Deck.Clear();
            Player1.PlayerHand.Cards.Clear();
            Player2.PlayerHand.Cards.Clear();

            foreach (Suit suit in Card.Suits)
            {
                for (int j = 2; j <= 9; j++)
                {
                    Card card = new($"{j}", j, suit);
                    Deck.Add(card);
                }

                Card ten = new("10", 0, suit);
                Deck.Add(ten);

                Card ace = new("A", 1, suit);
                Deck.Add(ace);

                Card jack = new("J", 0, suit);
                Deck.Add(jack);

                Card king = new("K", 0, suit);
                Deck.Add(king);

                Card queen = new("Q", 0, suit);
                Deck.Add(queen);
            }

            Deck.Sort(new CardShuffler());

            Debugger.Log($"Deck Size: {Deck.Count}/52");
            Debugger.Log("Setup deck");

            for(int i = 0; i < 2; i++)
            {
                AddCard(Player1);
                AddCard(Player2);
            }

            Debugger.Log("Setup Baccarat");
        }

        /// <summary>
        /// Gives a player a random card
        /// </summary>
        /// <param name="player">
        /// The player to add a card to
        /// </param>
        public void AddCard(BaccaratPlayer player)
        {
            Card card = Deck[new Random().Next(0, Deck.Count)];

            player.AddCard(card);
            Debugger.Log($"Gave {player.Name} card: {card}");
            Deck.Remove(card);
        }
    }
}

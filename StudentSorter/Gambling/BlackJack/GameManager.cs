using StudentSorter.Gambling.Cards;
using StudentSorter.Debug;

namespace StudentSorter.Gambling.BlackJack
{
    public class GameManager
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public int AceValue { get; set; }
        public List<Card> Deck = new();

        public GameManager(Player p1, Player p2)
        {
            Player1 = p1;
            Player2 = p2;
            AceValue = 11;
        }

        public void SetupGame()
        {
            Deck.Clear();
            Player1.Cards.Clear();
            Player2.Cards.Clear();

            foreach(Suit suit in Card.Suits)
            {
                for(int i = 2; i <= 10; i++)
                {
                    Card card = new($"{i}", i, suit);
                    Deck.Add(card);
                }

                Card ace = new("A", AceValue, suit);
                Deck.Add(ace);

                Card jack = new("J", 10, suit);
                Deck.Add(jack);

                Card king = new("K", 10, suit);
                Deck.Add(king);

                Card queen = new("Q", 10, suit);
                Deck.Add(queen);
            }

            Debugger.Log($"Deck Size: {Deck.Count}/52");
            Debugger.Log("Set up game.");
        }
    }
}

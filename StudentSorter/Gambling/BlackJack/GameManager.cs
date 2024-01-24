using StudentSorter.Gambling.Cards;
using StudentSorter.Debug;
using System.Data;

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

            AddCard(Player1);
            AddCard(Player1);
            AddCard(Player2);
            AddCard(Player2);

            Debugger.Log($"Deck Size: {Deck.Count}/52");
            Debugger.Log("Set up game.");
        }

        /// <summary>
        /// Gives a player a random card
        /// </summary>
        /// <param name="player">
        /// The player to give a card to
        /// </param>
        public void AddCard(Player player)
        {
            Card card = Deck[new Random().Next(0, Deck.Count - 1)];
            player.AddCard(card);
            Deck.Remove(card);

            Debugger.Log($"Gave {player} a random card.");
        }

        /// <summary>
        /// Updates a player's cards
        /// </summary>
        /// <param name="player">
        /// The player whose cards to update
        /// </param>
        /// <param name="view">
        /// The data grid containing the player's cards
        /// </param>
        public void UpdatePlayerCardList(Player player, DataTable view)
        {
            if(view.Rows.Count > 0)
                view.Rows.Clear();

            foreach(Card card in player.Cards)
                view.Rows.Add(card);
        }
        
        /// <summary>
        /// Returns who won the game
        /// </summary>
        /// <param name="player1">
        /// The first player
        /// </param>
        /// <param name="player2">
        /// The second player
        /// </param>
        /// <returns>
        /// The winner, or No One if the players
        /// tie
        /// </returns>
        public Player Winner(Player player1, Player player2)
        {
            if(player1.CardValue > player2.CardValue)
            {
                if (player1.CardValue <= 21) return player1;
            } 
            else
            {
                if(player2.CardValue <= 21) return player2;
            }

            return new Player("No One");
        }
    }
}

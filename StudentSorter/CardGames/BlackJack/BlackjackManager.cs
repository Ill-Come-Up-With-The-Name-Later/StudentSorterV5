using StudentSorter.Gambling.Cards;
using StudentSorter.Debug;
using System.Data;

namespace StudentSorter.Gambling.BlackJack
{
    public class BlackjackManager
    {
        public BlackjackPlayer Player1 { get; set; }
        public BlackjackPlayer Player2 { get; set; }
        public int AceValue { get; set; }
        public List<Card> Deck = new();

        public BlackjackManager(BlackjackPlayer p1, BlackjackPlayer p2)
        {
            Player1 = p1;
            Player2 = p2;
            AceValue = 11;
        }

        /// <summary>
        /// Sets up the game
        /// 
        /// Creates 3 decks and gives
        /// both players 2 cards
        /// </summary>
        public void SetupGame()
        {
            Deck.Clear();
            Player1.Cards.Clear();
            Player2.Cards.Clear();

            for (int i = 0; i < 3; i++)
            {
                foreach (Suit suit in Card.Suits)
                {
                    for (int j = 2; j <= 10; j++)
                    {
                        Card card = new($"{j}", j, suit);
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
            }

            for(int k = 0; k < 2; k++)
            {
                AddCard(Player1);
                AddCard(Player2);
            }

            Debugger.Log($"Deck Size: {Deck.Count}/52");
            Debugger.Log("Setup Blackjack.");
        }

        /// <summary>
        /// Gives a player a random card
        /// </summary>
        /// <param name="player">
        /// The player to give a card to
        /// </param>
        public void AddCard(BlackjackPlayer player)
        {
            Card card = Deck[new Random().Next(0, Deck.Count)];
            player.AddCard(card);
            Deck.Remove(card);

            Debugger.Log($"Gave {player.Name} a random card.");
        }

        /// <summary>
        /// Updates a player's cards
        /// </summary>
        /// <param name="player">
        /// The player whose cards to update
        /// </param>
        /// <param name="table">
        /// The data grid containing the player's cards
        /// </param>
        /// <param name="dataGrid">
        /// The data grid to update
        /// </param>
        public static void UpdatePlayerCardList(BlackjackPlayer player, DataTable table, DataGridView dataGrid, Label handVal, bool obfuscate = false)
        {
            if(table.Rows.Count > 0)
                table.Rows.Clear();

            for (int i = 0; i < player.Cards.Count; i++) {
                if (i == 0 || !obfuscate)
                {
                    table.Rows.Add(player.Cards[i].ToString());
                }

                if(i > 0 && obfuscate)
                {
                    table.Rows.Add("???");
                }
            }

            foreach (DataGridViewColumn column in dataGrid.Columns)
                column.Width = dataGrid.Width;

            handVal.Text = $"Player Hand Value: {player.CardValue}";
            Debugger.Log($"{player.Name}'s Cards: {player.Cards.Count} | Table Rows: {table.Rows.Count}");
            Debugger.Log($"{player.Name}'s Hand's Value: {player.CardValue}");
            Debugger.Log($"Updated cards for {player.Name}");
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
        public BlackjackPlayer? Winner(BlackjackPlayer player1, BlackjackPlayer player2, int turn, bool pStand = false)
        {
            if (player1.CardValue == 21 && player2.CardValue == 21)
            {
                Debugger.Log("Tie.");
                return new BlackjackPlayer("No One");
            }

            if(player1.CardValue == 21)
                return player1;

            if(player2.CardValue == 21)
                return player2;

            if (player1.CardValue > 21)
                return player2;

            if (player2.CardValue > 21) 
                return player1;

            if(pStand)
            {
                Debugger.Log($"{player1.Name} stood");

                if(player1.CardValue < 21 && player2.CardValue < 21)
                {
                    Debugger.Log("Both player have less than 21.");
                    if (player1.CardValue == player2.CardValue)
                    {
                        Debugger.Log($"{player1.Name} and {player2.Name} had card value {player1.CardValue} and tied");
                        return new BlackjackPlayer("No One");
                    }

                    if ((player1.CardValue > player2.CardValue) && (player1.CardValue <= 21))
                    {
                        Debugger.Log($"{player1.Name} wins with a higher value than {player2.Name}");
                        return player1;
                    }

                    if ((player2.CardValue > player1.CardValue) && (player2.CardValue <= 21))
                    {
                        Debugger.Log($"{player2.Name} wins with a higher value than {player1.Name}");
                        return player2;
                    }
                }
                
                if (player1.CardValue == player2.CardValue)
                {
                    Debugger.Log($"{player1.Name} and {player2.Name} had card value {player1.CardValue} and tied");
                    return new BlackjackPlayer("No One");
                }

                if ((player1.CardValue > player2.CardValue) && (player1.CardValue <= 21))
                {
                    Debugger.Log($"{player1.Name} wins with a higher value than {player2.Name}");
                    return player1;
                }

                if ((player2.CardValue > player1.CardValue) && (player2.CardValue <= 21))
                {
                    Debugger.Log($"{player2.Name} wins with a higher value than {player1.Name}");
                    return player2;
                }
            }

            Debugger.Log("No winner");
            return null;
        }
    }
}

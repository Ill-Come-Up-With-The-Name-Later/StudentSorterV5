using StudentSorter.Gambling.Cards;
using StudentSorter.Debug;

namespace StudentSorter.Gambling.BlackJack
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Cards = new();
        public int CardValue {  get; set; }

        /// <summary>
        /// Blackjack player
        /// </summary>
        /// <param name="name">
        /// The player's name
        /// </param>
        public Player(string name = "Player") 
        {
            Name = name;
            CardValue = 0;
        }

        /// <summary>
        /// Adds a card to a player's pile
        /// </summary>
        /// <param name="card">
        /// The card to add
        /// </param>
        public void AddCard(Card card)
        {
            Cards.Add(card);

            CardValue += card.Value;
            Debugger.Log($"Addedd {card} to player's cards.");
            Debugger.Log($"{Name}'s cards' value: {CardValue}");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

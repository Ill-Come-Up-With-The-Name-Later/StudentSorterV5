using StudentSorter.Gambling.Cards;
using StudentSorter.Debug;

namespace StudentSorter.Gambling.BlackJack
{
    public class BlackjackPlayer
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
        public BlackjackPlayer(string name = "Player") 
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

            if(card.Name.Contains('A'))
            {
                if(CardValue <= 10)
                {
                    card.Value = 11;
                } 
                else
                {
                    card.Value = 1;
                }
            }

            CardValue += card.Value;

            if(CardValue > 21)
            {
                foreach(Card pCard in Cards)
                {
                    if (pCard.Name.StartsWith('A') && pCard.Value == 11)
                    {
                        pCard.Value = 1;
                        CardValue -= 10;
                        break;
                    }
                }
            }

            Debugger.Log($"Addedd {card} to {Name}'s cards.");
            Debugger.Log($"{Name}'s cards' value: {CardValue}");
        }

        public override string ToString()
        {
            return $"{Name} - Card Value: {CardValue}";
        }
    }
}

using StudentSorter.CardGames.Cards;

namespace StudentSorter.CardGames.Baccarat.Player
{
    public class BaccaratPlayer
    {
        public string Name { get; set; }

        public Hand PlayerHand = new();

        public BaccaratPlayer(string name = "Name")
        {
            Name = name;

            PlayerHand.Owner = this;
        }

        /// <summary>
        /// Adds a card to the player's
        /// hand
        /// </summary>
        /// <param name="card">
        /// The card to add to the hand
        /// </param>
        public void AddCard(Card card)
        {
            PlayerHand.Cards.Add(card);
        }
    }
}

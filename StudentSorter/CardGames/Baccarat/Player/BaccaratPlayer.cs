namespace StudentSorter.CardGames.Baccarat.Player
{
    public class BaccaratPlayer
    {
        public string Name { get; set; }
        public Hand PlayerHand { get; set; }

        public BaccaratPlayer(string name, Hand playerHand)
        {
            Name = name;
            PlayerHand = playerHand;

            PlayerHand.Owner = this;
        }
    }
}

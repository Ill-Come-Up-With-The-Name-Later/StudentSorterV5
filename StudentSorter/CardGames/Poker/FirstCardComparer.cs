using StudentSorter.CardGames.Cards;
using StudentSorter.CardGames.Poker.Player;
using System.Collections;

namespace StudentSorter.CardGames.Poker
{
    public class FirstCardComparer : IComparer<PokerPlayer>
    {
        /// <summary>
        /// Compares two poker players' first cards
        /// </summary>
        /// <param name="x">
        /// A poker player
        /// </param>
        /// <param name="y">
        /// A poker player
        /// </param>
        /// <returns>
        /// The player with the greater value first card
        /// </returns>
        public int Compare(PokerPlayer? x, PokerPlayer? y)
        {
            if (x == null || y == null) return 0;
            Card xCard = x.PlayerHand.Cards[0];
            Card yCard = y.PlayerHand.Cards[0];

            xCard.Value = xCard.Name[0] switch
            {
                'A' => 14,
                'K' => 13,
                'Q' => 12,
                'J' => 11,
                _ => int.Parse(xCard.Name[0].ToString()),
            };

            yCard.Value = yCard.Name[0] switch
            {
                'A' => 14,
                'K' => 13,
                'Q' => 12,
                'J' => 11,
                _ => int.Parse(yCard.Name[0].ToString()),
            };

            if (xCard.Value > yCard.Value) return -1;
            if (xCard.Value < yCard.Value) return 1;
            if (xCard.Value == yCard.Value) return 0;

            return 0;
        }
    }
}

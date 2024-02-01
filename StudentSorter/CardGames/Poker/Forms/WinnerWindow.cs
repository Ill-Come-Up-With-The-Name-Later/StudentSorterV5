﻿using System.Data;
using StudentSorter.Debug;
using StudentSorter.Gambling.Cards;

namespace StudentSorter.CardGames.Poker.Forms
{
    public partial class WinnerWindow : Form
    {
        public PokerManager Manager { get; set; }

        public DataTable PlayerCards = new();
        public DataTable Player2Cards = new();
        public DataTable Player3Cards = new();
        public DataTable Player4Cards = new();

        public WinnerWindow(PokerManager manager)
        {
            InitializeComponent();
            Manager = manager;

            PlayerHand.DataSource = PlayerCards;
            Player2Hand.DataSource = Player2Cards;
            Player3Hand.DataSource = Player3Cards;
            Player4Hand.DataSource = Player4Cards;

            PlayerCards.Columns.Add("Card", typeof(string));
            Player2Cards.Columns.Add("Card", typeof(string));
            Player3Cards.Columns.Add("Card", typeof(string));
            Player4Cards.Columns.Add("Card", typeof(string));

            Player1BestHandLabel.Text = $"{Manager.Players[0].Name}'s Best Hand";
            Player2BestHandLabel.Text = $"{Manager.Players[1].Name}'s Best Hand";
            Player3BestHandLabel.Text = $"{Manager.Players[2].Name}'s Best Hand";
            Player4BestHandLabel.Text = $"{Manager.Players[3].Name}'s Best Hand";

            foreach (Card card in Manager.Players[0].PlayerHand.Cards)
                PlayerCards.Rows.Add(card);

            foreach (Card card in Manager.Players[1].PlayerHand.Cards)
                Player2Cards.Rows.Add(card);

            foreach (Card card in Manager.Players[2].PlayerHand.Cards)
                Player3Cards.Rows.Add(card);

            foreach (Card card in Manager.Players[3].PlayerHand.Cards)
                Player4Cards.Rows.Add(card);

            PokerWindow.UpdatePlayerCards(Manager.Players[0], PlayerCards, PlayerHand);
            PokerWindow.UpdatePlayerCards(Manager.Players[1], Player2Cards, Player2Hand);
            PokerWindow.UpdatePlayerCards(Manager.Players[2], Player3Cards, Player3Hand);
            PokerWindow.UpdatePlayerCards(Manager.Players[3], Player4Cards, Player4Hand);

            Debugger.Log("Displaying all players' best hands");
        }
    }
}
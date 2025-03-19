using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlackJackApp1.classes
{
    internal class Deck
    {
        internal classes.Card DealCard()
        {
            throw new NotImplementedException();
        }

        public class Card
        {
            public string Suit { get; }
            public string Rank { get; }
            public int Value { get; }

            public Card(string suit, string rank, int value)
            {
                Suit = suit;
                Rank = rank;
                Value = value;
            }

            public override string ToString()
            {
                return $"{Rank} of {Suit}";
            }
        }

        public class PlayerDeck
        {
            private List<Card> cards;
            private static Random rng = new Random();

            public PlayerDeck()
            {
                cards = new List<Card>();
                string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
                string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
                int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

                // Deck vullen met kaarten
                for (int i = 0; i < suits.Length; i++)
                {
                    for (int j = 0; j < ranks.Length; j++)
                    {
                        cards.Add(new Card(suits[i], ranks[j], values[j]));
                    }
                }

                Shuffle();
            }

            // Schudt de kaarten
            public void Shuffle()
            {
                int n = cards.Count;
                for (int i = n - 1; i > 0; i--)
                {
                    int j = rng.Next(i + 1);
                    (cards[i], cards[j]) = (cards[j], cards[i]);
                }
            }

            // Geeft een kaart uit het deck en verwijdert deze
            public Card DealCard()
            {
                if (cards.Count == 0)
                {
                    throw new InvalidOperationException("No more cards in the deck.");
                }

                Card dealtCard = cards[0];
                cards.RemoveAt(0);
                return dealtCard;
            }
        }

    }
}
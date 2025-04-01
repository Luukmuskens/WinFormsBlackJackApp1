using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlackJackApp1.classes
{
    internal class Hand
    {
        private List<Card> cards = new List<Card>();
        private int score;
        private bool won = false;
        private bool buse = false;
        private bool blackjack = false;
        private bool stand = false;

        public Hand()
        {
            cards = new List<Card>();
        }

        public void addCard(Card card)
        {
            cards.Add(card);
            CalculateScore();
        }

        public void CalculateScore()
        {
            score = 0;
            foreach (Card card in cards)
            {
                score += card.GetValue();
            }
            foreach (Card card in cards)
            {
                if (card.GetRank() == "A" && score > 21)
                {
                    Console.WriteLine("The score is " + score + "but an ace is adjusted from 11 to 1");
                    card.ChangeValue();
                    RecalculateScore();
                }
            }
        } public void RecalculateScore()
        {
            score = 0;
            foreach (Card card in cards)
            {
                score += card.GetValue();
            }
        }




    }
}

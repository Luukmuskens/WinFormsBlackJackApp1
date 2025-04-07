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

        public bool CheckBlackjack()
        {
            if (cards.Count == 2 && score == 21)
            {
                blackjack = true;
                return true;
            }
            return false;
        }

        public bool ChangeBust()
        {
            if (score > 21)
            {
                buse = true;
                return true;
            }
            return false;
        }

        public void CheckWon()
        { 
            won = score <= 21;
        }

        public void Stand()
        {
            stand = true;
        }
        
        public void GetIsHidden()
        {
            foreach (Card card in cards)
            {
                if (card.GetIsHidden())
                {
                    Console.WriteLine("Card is hidden");
                }
                else
                {
                    Console.WriteLine("Card is not hidden");
                }
            }
        }

        public void card.SetSuit(string suit)
        {
            foreach (Card card in cards)
            {
                card.SetSuit(suit);
            }
        }

        public void card.SetRank(string rank)
        {
            foreach (Card card in cards)
            {
                card.SetRank(rank);
            }
        }
        public void card.SetValue(int value)
        {
            foreach (Card card in cards)
            {
                card.SetValue(value);
            }
        }

        public void card.SetIsHidden(bool isHidden)
        {
            foreach (Card card in cards)
            {
                card.SetIsHidden(isHidden);
            }
        }
        public List<Card> GetCards()
        {
            return cards;
        }

        public void printCards()
        {
            foreach (Card card in cards)
            {
                if (!card.GetIsHidden())
                {
                    Console.WriteLine(card.GetSuit() + " " + card.GetRank());
                }
                else
                {
                    Console.WriteLine(" ? ?");
                }
            }
        }

        public int GetScore()
        {
            return score;
        }
        public bool GetWon()
        {
            return won;
        }
        public bool GetBuse()
        {
            return buse;
        }
        public bool GetBlackjack()
        {
            return blackjack;
        }
        public bool GetStand()
        {
            return stand;
        }
        public void Reset()
        {
            cards.Clear();
            score = 0;
            won = false;
            buse = false;
            blackjack = false;
            stand = false;
        }
        public List<Card> GetCards()
        {
            return cards;
        }
        public void SetCards(List<Card> newCards)
        {
            cards = newCards;
            CalculateScore();
        }
        public void SetScore(int newScore)
        {
            score = newScore;
        }







    }
}

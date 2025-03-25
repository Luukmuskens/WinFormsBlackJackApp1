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

        public void Setcard (Card card)
        {  
            cards.Add(new Card(card.getname(), Card.getvalue())); 
        }

        public List<Card> Getcards() { return cards; }

        internal List<Card> Getcard(object card)
        {
            throw new NotImplementedException();
        }

        internal List<Card> Getcard()
        {
            throw new NotImplementedException();
        }
    }
}

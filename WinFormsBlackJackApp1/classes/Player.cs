using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static WinFormsBlackJackApp1.classes.Deck;

namespace WinFormsBlackJackApp1.classes
{
    internal class Player
    {
        Hand Hand = new Hand();
        private int winstreak;
        public bool klaar = false;

        public void stand()
        {
            this.klaar = true;
        }
        public void hit(Card card)
        {
            Hand.Setcard(card);
        }
        public void playerwon()
        {
            this.winstreak++;
        }

        public void playershowhand()
        {
            List<Card> cards = Hand.Getcard();
            foreach (Card card in cards)
            {
                string first = card.GetType().Name;
                string second = card.GetValue();
                Console.WriteLine("card Name: " + first + " Value: " + second);
            }
        }
        public Hand Gethand()
        {
            return this.Hand;


        }
    }

    public class hand
    {
    }
}

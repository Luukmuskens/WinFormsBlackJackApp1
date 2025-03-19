using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlackJackApp1.classes
{
    internal class Form1
    {
        class Program
        {
            static void form1()
            {
                Deck deck = new Deck();
                Console.WriteLine("Deck shuffled!");

                // Trek een kaart
                Card card = deck.DealCard();
                Console.WriteLine($"You drew: {card}");

                // Nog een kaart trekken
                Card anotherCard = deck.DealCard();
                Console.WriteLine($"Next card: {anotherCard}");
            }
        }

    }
}

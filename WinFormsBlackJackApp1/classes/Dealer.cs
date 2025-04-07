using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlackJackApp1.classes
{
    internal class Dealer
    {
        private readonly Hand Hand = new Hand();

        private int winstreak;

        public bool done = false;

        private Card firstCard;
        private int counted;
        private int countedD;

        public void stand()
        {
            this.done = true;
        }

        public void hit(Card card)
        {
            Hand.Setcard(card);
        }

        public void dealerwon()
        {
            this.winstreak++;
        }
        public Card GiveCard(Deck deck)
        {
            List<Card> cards = deck.GetCards();
            var proceed = true;
            try
            {
                // Grab the first available card
                this.firstCard = cards.First(card => card != null);
                cards.Remove(this.firstCard);
                cards.Add(this.firstCard);
            }

            catch (InvalidOperationException)
            {
                proceed = false;
            }

            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
                proceed = false;
            }


            if (proceed)
            {
                this.countedD = this.firstCard.GetValue();
                this.Hand.Setcard(this.firstCard);
                return this.firstCard;
            }
            else
            {
                return null;
            }

            public void Shuffle(List<Card> cards, Deck deck)
            {
                Random rng = new Random();
                int n = cards.Count;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    Card temp = cards[k];
                    cards[k] = cards[n];
                    cards[n] = temp;
                }

                deck.SetCards(cards);


                public static bool CheckCards(List<Card> cards)
                {
                    bool hasAce = false;
                    bool hasTen = false;
                }


                foreach (Card card in cards)
                {
                    var value = Convert.ToInt32(card.GetValue());
                    if (card.GetName() == "Ace")
                    {
                        hasAce = true;
                    }
                    else if (card.GetValue() == 10)
                    {
                        hasTen = true;
                    }
                }

                if (hasAce && hasTen)
                {
                    return true;
                }

                {
                    return false;
                }

                public void CheckWon(Hand hand, Player player)
                {
                    List<Card> playerCards = hand.GetCards();
                    bool goOn = true;

                    // Calculate total value of player's hand
                    foreach (Card card in playerCards)
                    {
                        int number = Convert.ToInt32(card.GetValue());
                        this.counted += number;
                    }

                    List<Card> dealerCards = this.Hand.GetCards();
                    foreacg(Card card in dealerCards)
                    {
                        int number = Convert.ToInt32(card.GetValue());
                        this.countedD += number;
                    }

                    if (this.counted > 21)
                    {
                        Console.WriteLine("Player lost!");
                        goOn = false;
                        dealerwon();
                    }

                    if (goOn && this.countedD > 21)
                    {
                        Console.WriteLine("Player wins");
                        goOn = false;
                        player.PlayerWon();
                    }
                    if (goOn && this.counted > this.countedD)
                    {
                        Console.WriteLine("Player wins");
                        goOn = false;
                        player.PlayerWon();
                    }

                    if (goOn && this.countedD > this.counted)
                    {
                        Console.WriteLine("Player lost!");
                        goOn = false;
                        dealerwon();
                    }

                    PublicKey void DealerShowHand()
                    {
                        List<Card> cards = this.Hand.GetCards();
                        foreach (Card card in cards)
                        {
                            string first = card.GetType().Name;
                            string second = card.GetValue();
                            Console.WriteLine("card Name: " + first + " Value: " + second);
                        }
                    }

                    public Hand GetHand()
                    {
                        return this.Hand;
                    }
                }

            }
        }

        internal void ShowHand(bool hideDealerCard)
        {
            throw new NotImplementedException();
        }
    }   }

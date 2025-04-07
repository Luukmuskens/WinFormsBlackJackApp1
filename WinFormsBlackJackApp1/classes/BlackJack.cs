using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBlackJackApp1.classes
{
    internal class BlackJack
    {
        private Deck deck;
        private Player player;
        private Dealer dealer;


        // score counters
        private int playerWins = 0;
        private int dealerWins = 0;
        private int ties = 0;

        public BlackJack()
        {
            deck = new Deck();
            player = new Player();
            dealer = new Dealer();
        }

        public void ResetGame()
        {
            deck = new Deck();
            player = new Player();
            dealer = new Dealer();
        }
        public void ResetScore()
        {
            playerWins = 0;
            dealerWins = 0;
            ties = 0;
        }


        public void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Blackjack!");

            // Shuffle the deck
            deck.Shuffle();

            // Deal initial cards to player and dealer
            player.AddCard(deck.DealCard());
            dealer.AddCard(deck.DealCard());
            player.AddCard(deck.DealCard());
            dealer.AddCard(deck.DealCard());

            ShowHands(hideDealerCard: true);




            // Check for blackjack
            if (player.HasBlackjack())
            {
                Console.WriteLine("Player has blackjack!");
                return;
            }



            PlayerTurn();
            if (!player.IsBusted())
            {
                DealerTurn();
            }

            ShowHands(hideDealerCard: false);
            DetermineWinner();
        }

        private void ShowHands(bool hideDealerCard)
        {
            Console.WriteLine("Your hand:");
            player.ShowHand();
            Console.WriteLine($"Totaal: {player.HandValue()}\n");

            Console.WriteLine("Dealer's hand:");
            dealer.ShowHand(hideDealerCard);
            if (!hideDealerCard)
                Console.WriteLine($"Totaal: {dealer.HandValue()}\n");

        }

        private void PlayerTurn()
        {
            while (!player.IsBusted())
            {
                Console.Write(" 'hit' or 'stand'? ");
                string input = Console.ReadLine()?.ToLower();

            }
            if (input == "hit")
            {
                player.AddCard(deck.DealCard());
                ShowHands(hideDealerCard: true);
                if (player.IsBusted())
                {
                    Console.WriteLine("You busted!");
                }
            }
            else if (input == "stand")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'hit' or 'stand'.");
            }

            if (player.IsBusted())
                Console.WriteLine("You are bust!");
        }

        private void DealerTurn()
        {
            Console.WriteLine("\nDealer's beurt...");
            while (dealer.ShouldHit())
            {
                dealer.AddCard(deck.DealCard());
                ShowHands(hideDealerCard: false);
            }
            if (dealer.IsBusted())
            {
                Console.WriteLine("Dealer busted!");
            }
        }

        private void DetermineWinner()
        {
            int playerScore = player.HandValue();
            int dealerScore = dealer.HandValue();

            if (playerScore > 21)
            {
                Console.WriteLine("You busted! Dealer wins.");
            }
            else if (dealerScore > 21 || playerScore > dealerScore)
            {
                Console.WriteLine("You win!");
            }
            else if (playerScore < dealerScore)
            {
                Console.WriteLine("Dealer wins.");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        public string GetScore()
        {
            return $"Player won : {playerWins} | Dealer won: {dealerWins} | Draw: {ties}";
        }
    }

}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Hello. Now you're going to play a game \"Blackjack\"");
            // create and shuffle a deck
            Deck mainDeck = new Deck();
            mainDeck.Shuffle();

            //mainDeck.Print(); // For debug

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)

            //Init variables for card
            Card[] dealer = new Card[2];
            Card[] firstPlayer = new Card[2];
            Card[] secondPlayer = new Card[2];

            //Handing out cards

            for (int i = 0; i < 2; i++)
            {
                dealer[i] = mainDeck.TakeTopCard();
                firstPlayer[i] = mainDeck.TakeTopCard();
                secondPlayer[i] = mainDeck.TakeTopCard();
            }
            // flip all the cards over
            for (int i = 0; i < 2; i++)
            {
                dealer[i].FlipOver();
                firstPlayer[i].FlipOver();
                secondPlayer[i].FlipOver();
            }
            // print the cards for player 1
            Console.WriteLine("\nCard for Dealer:");
            for (int i = 0; i < 2; i++)
                Console.WriteLine((i + 1) + " card is " + dealer[i].Rank + " of " + dealer[i].Suit);
            // print the cards for player 2
            Console.WriteLine("\nCard for first player:");
            for (int i = 0; i < 2; i++)
                Console.WriteLine((i + 1) + " card is " + firstPlayer[i].Rank + " of " + firstPlayer[i].Suit);
            // print the cards for player 3
            Console.WriteLine("\nCard for second player:");
            for (int i = 0; i < 2; i++)
                Console.WriteLine((i + 1) + " card is " + secondPlayer[i].Rank + " of " + secondPlayer[i].Suit);
            Console.WriteLine();
        }
    }
}

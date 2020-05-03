using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{    
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            Deck test = new Deck();
            test.Print();
            // tell the deck to shuffle and print itself
            Console.WriteLine("Print shuffled desk:");
            test.Shuffle();
            test.Print();
            // take the top card from the deck and print the card rank and suit
            Card first = test.TakeTopCard();
            Console.WriteLine();
            Console.WriteLine("First card suit " + first.Suit + " and rank " + first.Rank);
            // take the top card from the deck and print the card rank and suit
            Card second = test.TakeTopCard();
            Console.WriteLine();
            Console.WriteLine("First card suit " + second.Suit + " and rank " + second.Rank);
        }
    }
}

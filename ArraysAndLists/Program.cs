using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {


        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var myNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // Create two Lists of type int.

            //Name one List "evens"
            var evens = new List<int>();
            // Name the other List "odds"
            var odds = new List<int>();


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * 
             * or the odds List
             */

            for (var i = 0; i > myNumbers.Length; i++)
            {
                if (myNumbers[i] % 2 == 0)
                {
                    evens.Add(myNumbers[i]);

                }
                else
                {
                    odds.Add(myNumbers[i]);
                }

            }
                /* Now using foeach or for loops,
                 * display each List of even and odd numbers
                 *
                 * Try to be creative in your display
                 * 
                 */
                foreach (var item in evens)
                {
                    Console.WriteLine(item);
                }
                foreach(var items in odds)
                {
                    Console.WriteLine(items);
                }
            
        }
    }
}

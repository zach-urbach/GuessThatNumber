using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // can you guess the number?
            Console.WriteLine("Let's play a game!");
           //call for the function
            GuessTheNum();
            //asking if the player wants to go again
            Console.WriteLine("Play again?");
            string answer = Console.ReadLine();
            string lower = answer.ToLower();
            if (lower == "yes")
            //starts the game again
            {
                GuessTheNum();
            }
            //telling the player goobye and ending the game
            if(lower == "no")
            {
              Console.WriteLine("Good bye.");
            }
            //keeps the console open
            Console.ReadKey();
        }

        static void GuessTheNum()
        {
            //the function
            Console.WriteLine("I am thinking of a number between 1 and 100.");
            //random number generator
            Random RNG = new Random();
            int randomNumber = RNG.Next(1, 101);
            //typeing in the guess
            Console.WriteLine("Type in your guess.");
            int Input = 0;
            while (Input != randomNumber)
            {
               
            }
            //end text with a twist
            Console.WriteLine("WAIT " + Input + "! that’s right, you win!");
        }


    }
}

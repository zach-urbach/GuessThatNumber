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
            else Console.WriteLine("Good bye.");
            Console.ReadKey();
        }
       
    }
}

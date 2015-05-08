using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decide a number from 1 to 100 to let the computer guess it: ");
            int userInput = Int32.Parse(Console.ReadLine());
            int computerGuess = 50, counter = 0, min=1, max=100;
            const int maxTrials = 7;

            while (userInput != computerGuess && counter <= maxTrials)
            {
                if (computerGuess > userInput)
                {
                    Console.WriteLine(string.Format("Computer guess {0} is higher  ", computerGuess));
                    max = computerGuess;
                    computerGuess = min + (max - min) / 2;
                }
                else if (computerGuess < userInput)
                {
                    Console.WriteLine(string.Format("Computer guess {0} is lower", computerGuess));
                    min = computerGuess;
                    computerGuess = max - (max - min) / 2;
                }

                Console.WriteLine("Min Range: " + min);
                Console.WriteLine("Max Range: " + max);
                Console.ReadLine();
                counter++;

                Console.WriteLine("Computer has {0} more trials \n", maxTrials - counter);
            }

            //Here the number matches & writes the result to console.
            Console.WriteLine(string.Format("Super! This time computer has made it. The user input is: {0}", computerGuess));
            Console.ReadLine();
        }
    }
}
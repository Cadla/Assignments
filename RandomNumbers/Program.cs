using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    public class Program
    {

        public static int CountTrails(int userInput, int minRange, int maxRange)
        {
            int counter = 1;
            const int maxTrials = 7;
            double computerGuess = Math.Round(((double)maxRange - (double)minRange) / 2);

            while (userInput != computerGuess)
            {
                Console.WriteLine("Computer's {0}th try \n", counter);

                if (computerGuess > userInput)
                {
                    Console.WriteLine(string.Format("Computer guess {0} is higher  ", computerGuess));
                    maxRange = (int)computerGuess;
                    computerGuess = minRange + (maxRange - minRange) / 2;
                }
                else if (computerGuess < userInput)
                {
                    Console.WriteLine(string.Format("Computer guess {0} is lower", computerGuess));
                    minRange = (int)computerGuess;
                    computerGuess = maxRange - (maxRange - minRange) / 2;
                }

                Console.WriteLine("Min Range: " + minRange);
                Console.WriteLine("Max Range: " + maxRange);
                //Console.ReadLine();
                counter++;                
            }
            return counter;
        }

        static void Main(string[] args)
        {
            int count = CountTrails(3, 2, 1008);
            //Here the number matches & writes the result to console.
            Console.WriteLine(string.Format("Super! Computer has made it in {0} trials!", count));
            Console.ReadLine();
        }
    }
}
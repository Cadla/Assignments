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
            bool isNotInRange = UserInputValidation(userInput, minRange, maxRange);

            if (isNotInRange)
            {
                Console.WriteLine("User input is not in range.");
                Console.ReadLine();
                Environment.Exit(0);
            }


            int counter = 1;
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

        private static bool UserInputValidation(int userInput, int minRange, int maxRange)
        {
            return (userInput < minRange || userInput > maxRange) ? true : false;                
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Collection of Numbers Program: \n");
            IsNumberInCollection(new int[] { 3, 4, 5, 6 }, 8);


            Console.WriteLine("Random Numbers Program: \n");
            int count = CountTrails(50, 101, 100);

            //Here the number matches & writes the result to console.
            Console.WriteLine(string.Format("Super! Computer has made it in {0} trials!", count));
            Console.ReadLine();
            
        }

        private static void IsNumberInCollection(IEnumerable<int> collection, int number)
        {
            if (collection.Contains(number))
                Console.WriteLine("{0} is in collection \n", number);
            else
                Console.WriteLine("{0} is not in collection \n", number);

            Console.WriteLine("Please press enter to move to Random Numbers program!");
            Console.ReadLine();
        }
    }
}
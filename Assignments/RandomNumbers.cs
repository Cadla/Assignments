using System;

namespace Assignments
{
    public class RandomNumbers
    {
        private static bool UserInputValidation(int userInput, int minRange, int maxRange)
        {
            return (userInput < minRange || userInput > maxRange) ? true : false;
        }

        public int CountTrails(int userInput, int minRange, int maxRange)
        {
            bool isNotInRange = UserInputValidation(userInput, minRange, maxRange);

            if (isNotInRange)
            {
                Console.WriteLine("User input is not in range.");
                Environment.Exit(0);
            }

            int counter = 1;
            double computerGuess = Math.Round(((double)maxRange - (double)minRange) / 2);

            while (userInput != computerGuess)
            {
                //Console.WriteLine("Computer's {0}th try \n", counter);

                if (computerGuess > userInput)
                {
                    //Console.WriteLine(string.Format("Computer guess {0} is higher  ", computerGuess));
                    maxRange = (int)computerGuess;
                    computerGuess = minRange + (maxRange - minRange) / 2;
                }
                else if (computerGuess < userInput)
                {
                    //Console.WriteLine(string.Format("Computer guess {0} is lower", computerGuess));
                    minRange = (int)computerGuess;
                    computerGuess = maxRange - (maxRange - minRange) / 2;
                }

                //Console.WriteLine("Min Range: " + minRange);
                //Console.WriteLine("Max Range: " + maxRange);
                counter++;
            }
            return counter;
        }
    }
}

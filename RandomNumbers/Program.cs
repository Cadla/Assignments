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
            int enteredNumber = Int32.Parse(Console.ReadLine());

            Random r = new Random();

            //Gets next random number ranging from 1 to 100.
            int computerGussedNumber = r.Next(1, 100);
            int counter = 0;
            int maxTrials = 7;

            while (enteredNumber != computerGussedNumber && counter <= maxTrials)
            {

                if (computerGussedNumber > enteredNumber)
                    Console.WriteLine(string.Format("Computer guess {0} is higher  ", computerGussedNumber));

                else if (computerGussedNumber < enteredNumber)
                    Console.WriteLine(string.Format("Computer guess {0} is lower", computerGussedNumber));

                computerGussedNumber = r.Next(1, 100);
                Console.ReadLine();
                counter++;

                if (counter == maxTrials)
                {
                    Console.WriteLine("Sorry computer. You've used maximum trials. Better luck next time!");
                    Console.ReadLine();
                    return;
                }
                else
                {
                    Console.WriteLine("Computer has {0} more trials \n", maxTrials - counter);
                }
                
            }

            //Here the number matches & writes the result to console.
            Console.WriteLine(string.Format("Super! This time computer has made it. The user input is: {0}", computerGussedNumber));
            Console.ReadLine();
        }

    }
}
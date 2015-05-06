using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        private static int GetMedian(List<int> list)
        {
            List<int> orderedList = list
                .OrderBy(numbers => numbers)
                .ToList();

            int listSize = orderedList.Count;
            int result;

            // even
            if (listSize % 2 == 0) 
            {
                int midIndex = listSize / 2;
                result = ((orderedList.ElementAt(midIndex - 1) +
                           orderedList.ElementAt(midIndex)) / 2);
            }
            // odd
            else 
            {
                double element = (double)listSize / 2;
                element = Math.Round(element, MidpointRounding.AwayFromZero);
                result = orderedList.ElementAt((int)(element - 1));
            }

            return result;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Decide a number from 1 to 100 to let the computer guess it: ");
            int enteredNumber = Int32.Parse(Console.ReadLine());

            Random r = new Random();

            //Computer .
            int computerGussedNumber = 50;
            int counter = 0;
            int maxTrials = 7;
            int min = 1;
            int max = 100;
            var list = new List<int>();

            while (enteredNumber != computerGussedNumber && counter <= maxTrials)
            {
                if (computerGussedNumber > enteredNumber)
                {
                    Console.WriteLine(string.Format("Computer guess {0} is higher  ", computerGussedNumber));
                    max = computerGussedNumber - 1;
                    
                    for (int i = min; i <= max; i++)
                    {
                        list.Add(i);
                    }
                    computerGussedNumber = GetMedian(list);

                }
                else if (computerGussedNumber < enteredNumber)
                {
                    Console.WriteLine(string.Format("Computer guess {0} is lower", computerGussedNumber));
                    min = computerGussedNumber + 1;
                    
                    for (int i = min; i <= max; i++)
                    {
                        list.Add(i);
                    }
                    computerGussedNumber = GetMedian(list);
                }

                Console.WriteLine("Min Range: " + min);
                Console.WriteLine("Max Range: " + max);

                Console.ReadLine();
                list.Clear();
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Decide a number from 1 to 100 to let the computer guess it: ");
            int enteredNumber = Int32.Parse(Console.ReadLine());

            Random r = new Random();

            //Gets next random number ranging from 1 to 100.
            int min = 1;
            int max = 100;
            int computerGussedNumber = r.Next(min, max);
            int counter = 0;
            int maxTrials = 7;

            while (enteredNumber != computerGussedNumber && counter <= maxTrials)
            {
                if (computerGussedNumber > enteredNumber)
                {
                    Console.WriteLine(string.Format("Computer guess {0} is higher  ", computerGussedNumber));
                    //Set max range by narrowing the search area. Set max
                    if (min < computerGussedNumber - 15 && enteredNumber < computerGussedNumber - 15)
                    {
                        max = computerGussedNumber - 15;
                        Console.WriteLine("Since {0} is too higher than user input, it's max range is reduced by 15", computerGussedNumber);
                    }
                    else if (min < computerGussedNumber - 10 && enteredNumber < computerGussedNumber - 10)
                    {
                        max = computerGussedNumber - 10;
                        Console.WriteLine("Since {0} is a bit higher it's max range is reduced by 10", computerGussedNumber);
                    }
                    else if (min < computerGussedNumber - 5 && enteredNumber < computerGussedNumber - 5)
                    {
                        max = computerGussedNumber - 5;
                        Console.WriteLine("Since {0} is little higher it's max range is reduced by 5", computerGussedNumber);
                    }
                    else
                    {
                        max = computerGussedNumber - 1;
                        Console.WriteLine("Since {0} is little higher it's max range is reduced by 1", computerGussedNumber);
                    }
                    
                    //Minimize search area. Take a number from min to current guess
                    computerGussedNumber = r.Next(min, max);

                }
                else if (computerGussedNumber < enteredNumber)
                {
                    Console.WriteLine(string.Format("Computer guess {0} is lower", computerGussedNumber));
                    // set min range from current system guess. Since it's lower let the system search from next number to current low.
                    if (max > computerGussedNumber + 15 && enteredNumber > computerGussedNumber + 15)
                    {
                        min = computerGussedNumber + 15;
                        Console.WriteLine("Since {0} is too lower than user input, it's min range is increased by 15", computerGussedNumber);
                    }
                    else if (max > computerGussedNumber + 10 && enteredNumber > computerGussedNumber + 10)
                    {
                        min = computerGussedNumber + 10;
                        Console.WriteLine("Since {0} is lower it's min range is increased by 10", computerGussedNumber);
                    }
                    else if (max > computerGussedNumber + 5 && enteredNumber > computerGussedNumber + 5)
                    {
                        min = computerGussedNumber + 5;
                        Console.WriteLine("Since {0} is a bit lower it's min range is increased by 5", computerGussedNumber);
                    }
                    else
                    {
                        min = computerGussedNumber + 1;
                        Console.WriteLine("Since {0} is a little lower it's min range is increased by 1", computerGussedNumber);
                    }
                    computerGussedNumber = r.Next(min, max);
                }


                Console.WriteLine("Computer Random Search Area: \nMinvalue: " + min.ToString());
                Console.WriteLine("Maxvalue: " + max.ToString());
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
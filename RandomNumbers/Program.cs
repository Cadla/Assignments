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

            Console.WriteLine("Decide a number to let the computer guess it: ");
            int enteredNumber = Int32.Parse(Console.ReadLine());

            Random r = new Random();

            //Gets next random number ranging from 1 to 10.
            int randomNumber = r.Next(1, 100);

            while (enteredNumber != randomNumber)
            {

                if (randomNumber > enteredNumber)
                    Console.WriteLine(string.Format("Computer guess {0} is higher  ", randomNumber));

                else if (randomNumber < enteredNumber)
                    Console.WriteLine(string.Format("Computer guess {0} is lower", randomNumber));

                randomNumber = r.Next(1, 100);
                Console.ReadLine();
            }

            //Here the number matches & writes the result to console.
            Console.WriteLine(string.Format("Super! This time computer has made it. The user input is: {0}", randomNumber));
            Console.ReadLine();
        }

    }
}
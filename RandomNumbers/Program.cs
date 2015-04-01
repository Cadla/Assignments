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
            //Gets the random number returned from method
            var resultRandomNumber = GetRandomNumber();

            //Printing the result out.
            Console.WriteLine(string.Format("Random Number From 1 to 100 is : {0}", resultRandomNumber));

            if (resultRandomNumber < 10)
                Console.WriteLine("Too low");
            if (resultRandomNumber > 90)
                Console.WriteLine("Too high");

            Console.ReadLine();
        }

        private static int GetRandomNumber()
        {
            //Creating a List to store numbers from 1 to 100
            List<int> randomList = new List<int>();

            //Adding numbers 1 by 1 upto 100
            for (int i = 1; i <= 100; i++)
            {
                randomList.Add(i);
            }

            // Random Class which gives a Random number every time
            Random rnd = new Random();

            //Storing fetched random number to a integer variable called "result"
            int result = rnd.Next(randomList.Count);

            return result;
        }
    }
}
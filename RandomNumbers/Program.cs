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

            Random r = new Random();

            //Gets next random number ranging from 1 to 10.
            int resultRandomNumber = r.Next(1, 100);

            //Enter a number to compare with random number
            Console.WriteLine("Please enter a number");
            int enteredNumber = Int32.Parse(Console.ReadLine());

            //Determine if the entered number is greater or less than system picked random number.
            while (enteredNumber != resultRandomNumber)
            {

                if (enteredNumber > resultRandomNumber)
                    Console.WriteLine(string.Format("{0} is higher than current random number", enteredNumber));

                else if (enteredNumber < resultRandomNumber)
                    Console.WriteLine(string.Format("{0} is lower than current random number", enteredNumber));

                //Entered number was not eaqul to random number. Give it a next try.
                Console.WriteLine("Please enter a new number");
                enteredNumber = Int32.Parse(Console.ReadLine());
            }

            //Here the number matches & writes the result to console.
            Console.WriteLine(string.Format("Super! You found correct random number: {0}", resultRandomNumber));
            Console.ReadLine();
        }

    }
}
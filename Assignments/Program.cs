using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Collection of Numbers Program:
            NumberCollection nc = new NumberCollection();
            bool test = false;
            bool isExisting = nc.IsNumberInCollection(new int[] { 3, 4, 5, 6, 7, 9, 10, 13, 15, 17 }, 8);

            if (isExisting)
            {
                Console.WriteLine("Given is in collection");
            }
            else
            {
                Console.WriteLine("Given is not in collection");
            }

            //Random Numbers Program()
            RandomNumbers rn = new RandomNumbers();
            int count = rn.CountTrails(50, 101, 100);
            //Here the number matches & writes the result to console.
            Console.WriteLine(string.Format("Super! Computer has made it in {0} trials!", count));
            Console.ReadLine();

        }

    }
}
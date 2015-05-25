using System;

namespace Assignments
{
    public class Program
    {

        static void Main(string[] args)
        {
            RandomNumberTimeCounter ts = new RandomNumberTimeCounter();

            #region NumberCollection

            NumberCollection nc = new NumberCollection();
            bool isExisting = nc.IsNumberInCollection(new int[] { 1, 7, 3, 5, 11, 9, 13, 15 }, 11);

            if (isExisting)
                Console.WriteLine("Given number is in collection");
            else
                Console.WriteLine("Given number is not in collection");

            Console.ReadLine();

            #endregion

            #region RandomNumbers
            //Random Numbers Program()
            //RandomNumbers rn = new RandomNumbers();
            //int count = rn.CountTrails(50, 1, 10000);
            ////Here the number matches & writes the result to console.
            //Console.WriteLine(string.Format("Super! Computer has made it in {0} trials!", count));
            //Console.ReadLine();
            #endregion

            #region RandomNumberTimeCounter
            //ts.CountTime();
            #endregion

        }

    }
}
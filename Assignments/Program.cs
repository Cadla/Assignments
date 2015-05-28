using System;
using System.Collections.Generic;

namespace Assignments
{
    public class Program
    {

        static void Main(string[] args)
        {
            
            #region NumberInSortedCollection

            //NumberInSortedCollection nc = new NumberInSortedCollection();

            //int[] array = new int[] { 8, 10, 2, 6, 3, 10 };
            //Array.Sort<int>(array);         

            //Console.WriteLine("Iterations:" + nc.IsNumberInSortedCollection(array, 6));
            //Console.ReadLine();

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
            RandomNumberTimeCounter ts = new RandomNumberTimeCounter();
            ts.CountTime();
            #endregion

        }

    }
}
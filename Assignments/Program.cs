using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignments
{
    public class Program
    {

        static void Main()
        {
            #region NumberInRecursiveFunction

            NumberInRecursiveFunction nc = new NumberInRecursiveFunction();

            int[] array = Enumerable.Range(1, 100).ToArray();
            //new int[] { 1, 3, 5, 7, 9 };

            Console.WriteLine("Iterations:" + nc.GetNumberInRecursiveFunction(array, 49, 0, array.Length - 1));
            Console.ReadLine();
                
            #endregion
            
            #region NumberInSortedCollection

            //NumberInSortedCollection nc = new NumberInSortedCollection();

            //int[] array = Enumerable.Range(1, 100).ToArray();
            //Array.Sort<int>(array);

            //Console.WriteLine("Iterations:" + nc.getNoOfIterationsToFindNumber(array, 50));
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
            //RandomNumberTimeCounter ts = new RandomNumberTimeCounter();
            //ts.CountTime();
            #endregion
           
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class NumberCollection
    {
        public bool IsNumberInCollection(IEnumerable<int> collection, int number)
        {
            int count = 0;

            var coll = collection.ToList();
            coll.Sort();

            foreach (var collNum in coll)
            {
                count++;
                if (collNum == number)
                {
                    Console.WriteLine("Iterations: " + count);
                    return true;
                }
            }
            Console.WriteLine("Iterations: " + count);
            return false;
        }        
    }
}
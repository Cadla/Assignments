using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignments
{
    public class NumberCollection
    {
        public bool IsNumberInCollection(IEnumerable<int> collection, int number)
        {
            int count = 0;

            var sortedCollection = collection.ToList();
            sortedCollection.Sort();
            var numberIndex = sortedCollection.IndexOf(number);

            if (numberIndex >= sortedCollection.Count() / 2)
                sortedCollection.Reverse();
            
            foreach (var collNum in sortedCollection)
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
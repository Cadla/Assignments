using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignments
{
    public class NumberInSortedCollection
    {
        public int IsNumberInSortedCollection(int[] collection, int number)
        {
            var numberIndex = Array.IndexOf<int>(collection, number);

            if (numberIndex >= collection.Count() / 2)
            {
                Array.Reverse(collection);
                numberIndex = Array.IndexOf<int>(collection, number);
            }   

            return ++numberIndex;
        }
    }
}
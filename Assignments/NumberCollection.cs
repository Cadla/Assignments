﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignments
{
    public class NumberCollection
    {
        public bool IsNumberInCollection(IEnumerable<int> collection, int number)
        {
            int count = 0;

            foreach (var collNum in collection)
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
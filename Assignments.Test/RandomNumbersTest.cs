using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignments.Test
{
    [TestClass]
    public class RandomNumbersTest
    {
        RandomNumbers rn = new RandomNumbers();
        [TestMethod]
        public void RandomNumbersTest1()
        {
            //First  
            const int min = 99;
            const int max = 1;
            int rangeLength = max - min + 1;
            int expected = (int)Math.Ceiling(Math.Log(rangeLength, 2));
            int actual = rn.CountTrails(99, 1, 10);
            Assert.IsTrue(actual <= expected);
        }

        [TestMethod]
        public void RandomNumbersTest2()
        {
            const int min = 50;
            const int max = 17;
            int rangeLength = max - min + 1;
            int expected = (int)Math.Ceiling(Math.Log(rangeLength, 2));
            int actual = rn.CountTrails(50, 17, 100);
            Assert.IsTrue(actual <= expected);
        }


        [TestMethod]
        public void RandomNumbersTest3()
        {
            int min = 1;
            int max = 100;
            int rangeLength = max - min + 1;
            int expected = (int)Math.Ceiling(Math.Log(rangeLength, 2));
            int actual = rn.CountTrails(99, 1, 100);
            Assert.IsTrue(actual <= expected);
        }

        [TestMethod]
        public void RandomNumbersTest4()
        {
            int min = 1;
            int max = 100;
            int rangeLength = max - min + 1;
            int expected = (int)Math.Ceiling(Math.Log(rangeLength, 2));
            int actual = rn.CountTrails(99, 1, 100);
            Assert.IsTrue(actual <= expected);
        }

        [TestMethod]
        public void RandomNumbersTest5()
        {
            int min = 100;
            int max = 100;
            int rangeLength = max - min + 1;
            int expected = (int)Math.Ceiling(Math.Log(rangeLength, 2));
            int actual = rn.CountTrails(99, 100, 100);
            Assert.IsTrue(actual <= expected);
        }

        [TestMethod]
        public void RandomNumbersTest6()
        {
            int min = 1;
            int max = 100;
            int rangeLength = max - min + 1;
            int expected = (int)Math.Ceiling(Math.Log(rangeLength, 2));
            int actual = rn.CountTrails(99, 1, 100);
            Assert.IsTrue(actual <= expected);

        }
    }
}

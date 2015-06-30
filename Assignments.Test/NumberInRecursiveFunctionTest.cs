using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Assignments.Test
{
    [TestClass]
    public class NumberInRecursiveFunctionTest
    {

        [TestMethod]
        public void NumberInRecursiveFunctionTest1()
        {
            NumberInRecursiveFunction rc = new NumberInRecursiveFunction();

            const int guessedIterations = 1;
            var iterationsFromMethod = rc.GetNumberInRecursiveFunction(new int[] { 2 }, 1, 0, 1);
            Assert.IsTrue(iterationsFromMethod <= guessedIterations);
        }

        [TestMethod]
        public void NumberInRecursiveFunctionTest2()
        {
            NumberInRecursiveFunction rc = new NumberInRecursiveFunction();

            const int guessedIterations = 3; // 5 elements 2 power 3, number not there shoud take 3 rounds
            var iterationsFromMethod = rc.GetNumberInRecursiveFunction(new int[] { 1, 3, 5, 7, 8 }, 1, 0, 1);
            Assert.IsTrue(iterationsFromMethod <= guessedIterations);
        }

        [TestMethod]
        public void NumberInRecursiveFunctionTest3()
        {
            NumberInRecursiveFunction rc = new NumberInRecursiveFunction();
            int[] array = Enumerable.Range(1, 100).ToArray(); 

            // 100 2 power 7
            const int guessedIterations = 7; 
            var iterationsFromMethod = rc.GetNumberInRecursiveFunction(array, 49, 0, array.Length - 1);
            Assert.IsTrue(iterationsFromMethod <= guessedIterations);
        }

        [TestMethod]
        public void NumberInRecursiveFunctionTest4()
        {
            NumberInRecursiveFunction rc = new NumberInRecursiveFunction();
            int[] array = Enumerable.Range(1, 1000000).ToArray();  //20
            const int guessedIterations = 20;
            var iterationsFromMethod = rc.GetNumberInRecursiveFunction(array, 49, 0, array.Length - 1);
            Assert.IsTrue(iterationsFromMethod <= guessedIterations);
        }

        [TestMethod]
        public void NumberInRecursiveFunctionTest5()
        {
            NumberInRecursiveFunction rc = new NumberInRecursiveFunction();

            const int guessedIterations = 1;
            var iterationsFromMethod = rc.GetNumberInRecursiveFunction(new int[] { 2 }, 1, 0, 1);
            Assert.IsTrue(iterationsFromMethod <= guessedIterations);
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNumbers;

namespace UnitTest
{

    [TestClass]
    public class UnitTest1
    {
        Program p = new Program();

        [TestMethod]
        public void TestMethod1()
        {
            //First  
            Program.TrianlgeSidesInput(10, 10, 15);
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Second Test  
            Trigonometric.TrianlgeSidesInput(10.5, 10.5, 15);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Thisrd Test  
            Trigonometric.TrianlgeSidesInput(10.5, 12.5, 15.5);

        }
    }
}
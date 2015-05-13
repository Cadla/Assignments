using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomNumbers;

namespace UnitTest
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //First  
            Program.CountTrails(50, 1, 100);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Second Test  
            Program.CountTrails(50, 1, 1000);

        }
        [TestMethod]
        public void TestMethod3()
        {
            //Third Test  
            Program.CountTrails(50, 17, 100);
        }


        [TestMethod]
        public void TestMethod4()
        {
            Program.CountTrails(51, 1, 100);
        }

        [TestMethod]
        public void TestMethod5()
        {
            Program.CountTrails(50, 200, 400);
        }

        [TestMethod]
        public void TestMethod6()
        {
            //Sixth  
            Program.CountTrails(50, 1, 100);
        }

        [TestMethod]
        public void TestMethod7()
        {
            Program.CountTrails(99, 1, 100);
        }

        [TestMethod]
        public void TestMethod8()
        {
            Program.CountTrails(-10, 1, 100);

        }
        [TestMethod]
        public void TestMethod9()
        {
            Program.CountTrails(0, -199, 100);
        }

        [TestMethod]
        public void TestMethod10()
        {
            Program.CountTrails(1, 50, 100);
        }

    }
}
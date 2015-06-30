using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Assignments.Test
{
    [TestClass]
    public class NumberCollectionTest
    {
        NumberCollection nc = new NumberCollection();

        [TestMethod]
        public void NumberCollection1()
        {
            bool isExsisting = nc.IsNumberInCollection(Enumerable.Range(1, 100), 75);
            Assert.IsTrue(isExsisting);
        }

        [TestMethod]
        public void NumberCollection2()
        {
            bool isExsisting = nc.IsNumberInCollection(Enumerable.Range(1, 100), 46);
            Assert.IsTrue(isExsisting);
        }

        [TestMethod]
        public void NumberCollection3()
        {
            bool isExsisting = nc.IsNumberInCollection(Enumerable.Range(1, 100), 1);
            Assert.IsTrue(isExsisting);
        }

        [TestMethod]
        public void NumberCollection4()
        {
            bool isExsisting = nc.IsNumberInCollection(Enumerable.Range(1, 100), 100);
            Assert.IsTrue(isExsisting);
        }

        [TestMethod]
        public void NumberCollection5()
        {
            //IEnumerable<int> squares = Enumerable.Range(4, 3)

            bool isExsisting = nc.IsNumberInCollection(new int[] { 3, 4, 5, 6, 7, 9, 8, 10, 13, 15, 17 }, 8);
            Assert.IsTrue(isExsisting);
        }
    }
}

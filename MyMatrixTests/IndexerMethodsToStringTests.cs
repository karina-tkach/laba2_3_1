using laba2_3_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrixTests
{
    [TestClass]
    public class IndexerMethodsToStringTests
    {
        [TestMethod]
        public void IndexerGet()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 3, 4 }, { 5, 8, 3 } });
            double expected = 8;
            double actual = m[1, 1];
            Assert.AreEqual(expected, actual, $"Indexer is wrong");
        }
        [TestMethod]
        public void IndexerSet()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 3, 4 }, { 5, 8, 3 } });
            m[0, 1] = 0;
            double expected = 0;
            double actual = m[0, 1];
            Assert.AreEqual(expected, actual, $"Indexer is wrong");
        }
        [TestMethod]
        public void Get()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 3, 4 }, { 5, 8, 3 }, { 7, 7, 7 } });
            double expected = 3;
            double actual = m.GetElement(1, 2);
            Assert.AreEqual(expected, actual, $"GetElement method is wrong");
        }
        [TestMethod]
        public void Set()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 3, 4 }, { 5, 8, 3 }, { 7, 7, 7 } });
            double expected = 0;
            m.SetElement(1, 2, 0);
            double actual = m.GetElement(1, 2);
            Assert.AreEqual(expected, actual, $"SetElement method is wrong");
        }
        [TestMethod]
        public void ToString1()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 3, 4 }, { 5, 8, 3 }, { 7, 7, 7 } });
            string expected = "1\t3\t4\n5\t8\t3\n7\t7\t7\n";
            string actual = m.ToString();
            Assert.AreEqual(expected, actual, $"ToString method is wrong");
        }
        [TestMethod]
        public void ToString2()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1 }, { 8}, { 7} });
            string expected = "1\n8\n7\n";
            string actual = m.ToString();
            Assert.AreEqual(expected, actual, $"ToString method is wrong");
        }
    }
}

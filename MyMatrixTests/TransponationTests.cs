using laba2_3_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrixTests
{
    [TestClass]
    public class TransponationTests
    {
        [TestMethod]
        public void Matrix3x3()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 2, 3 }, { 4, 5, 7 }, { 3, 3, 1 } });
            string expected = new MyMatrix(new double[,] { { 1, 4, 3 }, { 2, 5, 3 }, { 3, 7, 1 } }).ToString();
            string actual = m.GetTransposedCopy().ToString();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} transponation is wrong");
        }
        [TestMethod]
        public void Matrix2x5()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 2, 3, 4, 5 }, { 4, 5, 6, 7, 8 } });
            string expected = new MyMatrix(new double[,] { { 1, 4 }, { 2, 5 }, { 3, 6 }, { 4, 7 }, { 5, 8 } }).ToString();
            string actual = m.GetTransposedCopy().ToString();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} transponation is wrong");
        }
        [TestMethod]
        public void Matrix5x3()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 4, 5 }, { 2, 5, 1 }, { 3, 6, 5 }, { 4, 7, 0 }, { 5, 8, 3 } });
            string expected = new MyMatrix(new double[,] { { 1, 2, 3, 4, 5 }, { 4, 5, 6, 7, 8 }, { 5, 1, 5, 0, 3 } }).ToString();
            string actual = m.GetTransposedCopy().ToString();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} transponation is wrong");
        }
        [TestMethod]
        public void Matrix1x6()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 4, 5, 5, 8, 3 } });
            string expected = new MyMatrix(new double[,] { { 1 }, { 4 }, { 5 }, { 5 }, { 8 }, { 3 } }).ToString();
            string actual = m.GetTransposedCopy().ToString();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} transponation is wrong");
        }
        [TestMethod]
        public void Matrix5x1()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1 }, { 4 }, { 5 }, { 5 }, { 8 } });
            string expected = new MyMatrix(new double[,] { { 1, 4, 5, 5, 8 } }).ToString();
            string actual = m.GetTransposedCopy().ToString();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} transponation is wrong");
        }
        [TestMethod]
        public void Matrix3x3Self()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 2, 3 }, { 4, 5, 7 }, { 3, 3, 1 } });
            string expected = new MyMatrix(new double[,] { { 1, 4, 3 }, { 2, 5, 3 }, { 3, 7, 1 } }).ToString();
            m.TransponeMe();
            string actual = m.ToString();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} self-transponation is wrong");
        }
        [TestMethod]
        public void Matrix2x5Self()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 2, 3, 4, 5 }, { 4, 5, 6, 7, 8 } });
            string expected = new MyMatrix(new double[,] { { 1, 4 }, { 2, 5 }, { 3, 6 }, { 4, 7 }, { 5, 8 } }).ToString();
            m.TransponeMe();
            string actual = m.ToString();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} self-transponation is wrong");
        }
        [TestMethod]
        public void Matrix5x3Self()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 4, 5 }, { 2, 5, 1 }, { 3, 6, 5 }, { 4, 7, 0 }, { 5, 8, 3 } });
            string expected = new MyMatrix(new double[,] { { 1, 2, 3, 4, 5 }, { 4, 5, 6, 7, 8 }, { 5, 1, 5, 0, 3 } }).ToString();
            m.TransponeMe();
            string actual = m.ToString();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} self-transponation is wrong");
        }
        [TestMethod]
        public void Matrix1x6Self()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 4, 5, 5, 8, 3 } });
            string expected = new MyMatrix(new double[,] { { 1 }, { 4 }, { 5 }, { 5 }, { 8 }, { 3 } }).ToString();
            m.TransponeMe();
            string actual = m.ToString();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} self-transponation is wrong");
        }
        [TestMethod]
        public void Matrix5x1Self()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1 }, { 4 }, { 5 }, { 5 }, { 8 } });
            string expected = new MyMatrix(new double[,] { { 1, 4, 5, 5, 8 } }).ToString();
            m.TransponeMe();
            string actual = m.ToString();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} self-transponation is wrong");
        }
    }
}

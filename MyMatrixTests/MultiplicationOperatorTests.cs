using laba2_3_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrixTests
{
    [TestClass]
    public class MultiplicationOperatorTests
    {
        [TestMethod]
        public void Matrix1x1()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1 } });
            MyMatrix m1 = new MyMatrix(new double[,] { { 4 } });
            string expected = "4\n";
            string actual = (m * m1).ToString();
            Assert.AreEqual(expected, actual, $"For matrices {m.ToString()} and {m1.ToString()} multiplication is wrong");
        }
        [TestMethod]
        public void Matrix5x3()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 2, 3 }, { 4, 5, 7 }, { 3, 3, 1 }, { 3, 3, 1 }, { 8, 5, 2 } });
            MyMatrix m1 = new MyMatrix(new double[,] { { 6, 1, 0, 3 }, { 0, 0, 0, 1 }, { 2, 3, 2, 4 } });
            string expected = new MyMatrix(new double[,] { { 12, 10, 6, 17 }, { 38, 25, 14, 45 }, { 20, 6, 2, 16 }, { 20, 6, 2, 16 }, { 52, 14, 4, 37 } }).ToString();
            string actual = (m * m1).ToString();
            Assert.AreEqual(expected, actual, $"For matrices {m.ToString()} and {m1.ToString()} multiplication is wrong");
        }
        [TestMethod]
        public void Matrix3x1()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1 }, { 4 }, { 3 } });
            MyMatrix m1 = new MyMatrix(new double[,] { { 9, 6, 7, 8, 4 } });
            string expected = new MyMatrix(new double[,] { { 9, 6, 7, 8, 4 }, { 36, 24, 28, 32, 16 }, { 27, 18, 21, 24, 12 } }).ToString();
            string actual = (m * m1).ToString();
            Assert.AreEqual(expected, actual, $"For matrices {m.ToString()} and {m1.ToString()} multiplication is wrong");
        }
        [TestMethod]
        public void Matrix4x4()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 2, 3, 5 }, { 4, 5, 7, 6 }, { 3, 3, 1, 0 }, { 4, 5, 7, 6 } });
            MyMatrix m1 = new MyMatrix(new double[,] { { 9, 8, 7, 5 }, { 6, 5, 3, 4 }, { 7, 7, 9, 10 }, { 6, 5, 3, 4 } });
            string expected = new MyMatrix(new double[,] { { 72, 64, 55, 63 }, { 151, 136, 124, 134 }, { 52, 46, 39, 37 }, { 151, 136, 124, 134 } }).ToString();
            string actual = (m * m1).ToString();
            Assert.AreEqual(expected, actual, $"For matrices {m.ToString()} and {m1.ToString()} multiplication is wrong");
        }
        [TestMethod]
        public void DifferentMatrices()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 2, 3 }, { 4, 5, 7 }, { 3, 3, 1 } });
            MyMatrix m1 = new MyMatrix(new double[,] { { 1, 2, 5 }, { 4, 5, 5 } });
            Assert.ThrowsException<InvalidOperationException>(() => m * m1);
        }
    }
}

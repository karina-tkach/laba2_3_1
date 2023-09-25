using laba2_3_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrixTests
{
    [TestClass]
    public class PlusOperatorTests
    {
        [TestMethod]
        public void Matrix1x1()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1 } });
            MyMatrix m1 = new MyMatrix(new double[,] { { 4 } });
            string expected = "5\n";
            string actual = (m+m1).ToString();
            Assert.AreEqual(expected, actual, $"For matrices {m.ToString()} and {m1.ToString()} addition is wrong");
        }
        [TestMethod]
        public void Matrix3x5()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 2, 3 }, { 4, 5, 7 }, { 3, 3, 1 }, { 3, 3, 1 }, { 8, 5, 2 } });
            MyMatrix m1 = new MyMatrix(new double[,] { { 6, 1, 0 }, { 0, 0, 0 }, { 2, 3, 2 }, { 1, 3, 1 }, { 0, 4, 1 } });
            string expected = new MyMatrix(new double[,] { { 7, 3, 3 }, { 4, 5, 7 }, { 5, 6, 3 }, { 4, 6, 2 }, { 8, 9, 3 } }).ToString();
            string actual = (m + m1).ToString();
            Assert.AreEqual(expected, actual, $"For matrices {m.ToString()} and {m1.ToString()} addition is wrong");
        }
        [TestMethod]
        public void Matrix3x1()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1}, { 4 }, { 3} });
            MyMatrix m1 = new MyMatrix(new double[,] { { 9 }, { 6 }, { 7 } });
            string expected = new MyMatrix(new double[,] { { 10 }, { 10 }, { 10 } }).ToString();
            string actual = (m + m1).ToString();
            Assert.AreEqual(expected, actual, $"For matrices {m.ToString()} and {m1.ToString()} addition is wrong");
        }
        [TestMethod]
        public void Matrix4x4()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 2, 3,5 }, { 4, 5, 7,6 }, { 3, 3, 1,0 }, { 4, 5, 7, 6 } });
            MyMatrix m1 = new MyMatrix(new double[,] { { 9, 8, 7, 5 }, { 6, 5, 3, 4 }, { 7, 7, 9, 10 }, { 6, 5, 3, 4 } });
            string expected = new MyMatrix(new double[,] { { 10, 10, 10, 10 }, { 10, 10, 10, 10 }, { 10, 10, 10, 10 }, { 10, 10, 10, 10 } }).ToString();
            string actual = (m + m1).ToString();
            Assert.AreEqual(expected, actual, $"For matrices {m.ToString()} and {m1.ToString()} addition is wrong");
        }
        [TestMethod]
        public void DifferentMatrices()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 2, 3 }, { 4, 5, 7 }, { 3, 3, 1 } });
            MyMatrix m1 = new MyMatrix(new double[,] { { 1, 2 }, { 4, 5 }, { 3, 3 } });
            Assert.ThrowsException<InvalidOperationException>(() => m + m1);
        }
    }
}

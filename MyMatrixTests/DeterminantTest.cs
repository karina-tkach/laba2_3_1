using laba2_3_1;
using Xunit.Sdk;

namespace MyMatrixTests
{
    [TestClass]
    public class DeterminantTest
    {
        [TestMethod] 
        public void Determinant1x1()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 2 } });
            double expected = 2;
            double? actual = m.CalcDeterminant();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} determinant is wrong");
        }
        [TestMethod]
        public void Determinant2x2()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 3, 5 }, { 4, 6 } });
            double expected = -2;
            double? actual = (double?)Math.Round((decimal)(m.CalcDeterminant()));
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} determinant is wrong");
        }
        [TestMethod]
        public void Determinant3x3()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 2, 5, -3 }, { 1, 4, -2 }, { -7, 3, 0 } });
            double expected = -11;
            double? actual = m.CalcDeterminant();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} determinant is wrong");
        }
        [TestMethod]
        public void Determinant4x4()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 5, 7, 1, 4 }, { 2, -3, -4, 2 }, { 3, 2, 1, 1 }, { 2, 4, 3, -1 } });
            double expected = 75;
            double? actual = (double?)Math.Round((decimal)(m.CalcDeterminant()));
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} determinant is wrong");
        }
        [TestMethod]
        public void DeterminantRowOfZeros()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 5, 7, 1, 4 }, { 0, 0, 0, 0 }, { 3, 2, 1, 1 }, { 2, 4, 3, -1 } });
            double expected = 0;
            double? actual = m.CalcDeterminant();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} determinant is wrong");
        }
        [TestMethod]
        public void DeterminantColumnOfZeros()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 2, 5, 0 }, { 1, 4, 0 }, { -7, 3, 0 } });
            double expected = 0;
            double? actual = m.CalcDeterminant();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} determinant is wrong");
        }
        [TestMethod]
        public void DeterminantProportionalColumns()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 2, 6, 0 }, { 1, 3, 1 }, { -7, -21, 1 } });
            double expected = 0;
            double? actual = m.CalcDeterminant();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} determinant is wrong");
        }
        [TestMethod]
        public void DeterminantProportionalRows()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 2, 5, 0 }, { 10, 25, 0 }, { -7, 3, 45 } });
            double expected = 0;
            double? actual = m.CalcDeterminant();
            Assert.AreEqual(expected, actual, $"For matrix {m.ToString()} determinant is wrong");
        }
        [TestMethod]
        public void DeterminantException()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 2, 5, 0 }, { 10, 25, 0 }, { -7, 3, 45 }, { -7, 3, 45 } });
            Assert.ThrowsException<InvalidOperationException>(()=>m.CalcDeterminant());
        }
        [TestMethod]
        public void DeterminantValidationForNotChangingState()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 2, 5, -3 }, { 1, 4, -2 }, { -7, 3, 0 } });
            string expected = "2\t5\t-3\n1\t4\t-2\n-7\t3\t0\n";
            double? det = m.CalcDeterminant();
            string actual = m.ToString();
            Assert.AreEqual(expected, actual, $"Determinant method changes state of matrix");
        }
    }
}
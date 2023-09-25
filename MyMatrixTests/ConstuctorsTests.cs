using laba2_3_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrixTests
{
    [TestClass]
    public class ConstuctorsTests
    {
        [TestMethod]
        public void CopyConstructor()
        {
            MyMatrix m = new MyMatrix(new double[,] { { 1, 3, 4 }, { 5, 8, 3 } });
            MyMatrix m1 = new MyMatrix(m);
            string expected = m.ToString();
            string actual = m1.ToString();
            Assert.AreEqual(expected, actual, $"Copy constructor is wrong");
        }
        [TestMethod]
        public void JaggedArrayConstructor()
        {
            MyMatrix m = new MyMatrix(new double[][] { new double[] { 1, 2, 3 }, new double[] { 4, 5, 7 }, new double[] { 3, 3, 1 }, new double[] { 3, 3, 1 } });
            string expected = new MyMatrix(new double[,] { { 1, 2, 3 }, { 4, 5, 7 }, { 3, 3, 1 }, { 3, 3, 1 } }).ToString();
            string actual = m.ToString();
            Assert.AreEqual(expected, actual, $"Constructor which accepts jagged array does't work right");
        }
        [TestMethod]
        public void JaggedArrayConstructorNot2Dimensional()
        {
            Assert.ThrowsException<Exception>(() => new MyMatrix(new double[][] { new double[] { 1, 2, 3, 3 }, new double[] { 4, 5, 7, 4, 5 }, new double[] { 3, 3, 1 } }));
        }
        [TestMethod]
        public void StringArrayConstructor()
        {
            string[] arr = { "5 7 4 33 9", "3 2 4 5 7", "11 4 6 4 3" };
            MyMatrix m = new MyMatrix(arr);
            string expected = "5\t7\t4\t33\t9\n3\t2\t4\t5\t7\n11\t4\t6\t4\t3\n";
            string actual = m.ToString();
            Assert.AreEqual(expected, actual, $"Constructor which accepts string array does't work right");
        }
        [TestMethod]
        public void StringArrayConstructorInappropriateCount()
        {
            string[] arr = {"5 7 4 33 9","3 2 4 5","11 4 6 4 3" };
            Assert.ThrowsException<Exception>(() => new MyMatrix(arr));
        }
        [TestMethod]
        public void StringArrayConstructorNotNumbers()
        {
            string[] arr = { "5 7 4 33 9", "3 2 a 5 7", "11 4 6 4 3" };
            Assert.ThrowsException<FormatException>(() => new MyMatrix(arr));
        }
        [TestMethod]
        public void StringConstructor()
        {
            string str =  "5 7\t4 33 9\n3 2 4 5 7\n11 4\t6 4 3" ;
            MyMatrix m = new MyMatrix(str);
            string expected = "5\t7\t4\t33\t9\n3\t2\t4\t5\t7\n11\t4\t6\t4\t3\n";
            string actual = m.ToString();
            Assert.AreEqual(expected, actual, $"Constructor which accepts string does't work right");
        }
    }
}

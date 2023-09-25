using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2_3_1
{
    public partial class MyMatrix
    {
        private double[,] matrix;
        private double? determinant;
        public int Height
        {
            get
            {
                return matrix.GetLength(0);
            }
        }

        public int Width
        {
            get
            {
                return matrix.GetLength(1);
            }
        }
        public int getHeight()
        {
            return Height;
        }
        public int getWidth()
        {
            return Width;
        }
        public MyMatrix(MyMatrix m)
        {
            this.matrix = new double[m.Height, m.Width];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    matrix[i, j] = m[i, j];
                }
            }
        }
        public MyMatrix(double[,] arr)
        {
            this.matrix = (double[,])arr.Clone();
        }
        public MyMatrix(double[][] m)
        {
            int len = m[0].Length;
            for (int i = 1; i < m.Length; i++)
            {
                if (m[i].Length != len)
                {
                    throw new Exception("Input array is not 2-dimensional");
                }
            }

            //int len = m.GroupBy(row => row.Length).Single().Key; // throws InvalidOperationException if source is not rectangular

            this.matrix = new double[m.Length, len];
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    matrix[i, j] = m[i][j];
                }
            }
        }
        public MyMatrix(string[] str)
        {
            int length = str[0].Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            this.matrix = new double[str.Length, length];

            for (int i = 0; i < str.Length; i++)
            {
                double[] arr = Array.ConvertAll(str[i].Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries), double.Parse);
                if (arr.Length != length)
                {
                    throw new Exception("Different count of numbers in string");
                }
                for (int j = 0; j < length; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }
        }
        public MyMatrix(string str) : this(str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries))
        {
            //string[] s = str.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //int length = s[0].Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
            //this.matrix = new double[s.Length, length];

            //for (int i = 0; i < s.Length; i++)
            //{
            //    double[] arr = Array.ConvertAll(s[i].Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries), double.Parse);
            //    if (arr.Length != length)
            //    {
            //        throw new Exception("Dif numb count");
            //    }
            //    for (int j = 0; j < length; j++)
            //    {
            //        matrix[i, j] = arr[j];
            //    }
            //}
        }
        public double this[int row, int col]
        {
            get
            {
                return matrix[row, col];
            }
            set
            {
                matrix[row, col] = value;
                determinant = null;
            }
        }
        public double GetElement(int row, int col)
        {
            return matrix[row, col];
        }
        public void SetElement(int row, int col, double value)
        {
            matrix[row, col] = value;
            determinant = null;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                str = str.Append(matrix[i, 0].ToString());
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    str = str.Append('\t' + matrix[i, j].ToString());
                }
                str = str.Append('\n');
            }
            return str.ToString();
        }
    }
}
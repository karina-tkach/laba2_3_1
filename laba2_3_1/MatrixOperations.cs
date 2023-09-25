using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2_3_1
{
    public partial class MyMatrix
    {
        public static MyMatrix operator +(MyMatrix m1, MyMatrix m2)
        {
            if (m1.Height != m2.Height || m1.Width != m2.Width)
            {
                throw new InvalidOperationException("Matrices have different size");
            }
            double[,] arr = new double[m1.Height, m1.Width];

            for (int i = 0; i < m1.Height; i++)
            {
                for (int j = 0; j < m1.Width; j++)
                {
                    arr[i, j] = m1[i, j] + m2[i, j];
                }
            }

            return new MyMatrix(arr);
        }
        public static MyMatrix operator *(MyMatrix m1, MyMatrix m2)
        {
            if (m1.Width != m2.Height)
            {
                throw new InvalidOperationException("Matrices have inappropriate size for multiplication");
            }
            double[,] arr = new double[m1.Height, m2.Width];

            for (int a = 0; a < m2.Width; a++)
            {
                for (int i = 0; i < m1.Height; i++)
                {
                    for (int j = 0; j < m1.Width; j++)
                    {
                        arr[i, a] += m1[i, j] * m2[j, a];
                    }
                }
            }
            return new MyMatrix(arr);
        }
        private double[,] GetTransposedArray()
        {
            double[,] arr = new double[Width, Height];

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    arr[i, j] = matrix[j, i];
                }
            }
            return arr;
        }
        public MyMatrix GetTransposedCopy()
        {
            return new MyMatrix(this.GetTransposedArray());
        }
        public void TransponeMe()
        {
            //or priate set to properties
            MyMatrix newMatrix = new MyMatrix(this.GetTransposedArray());
            this.matrix = new double[newMatrix.Height, newMatrix.Width];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    matrix[i, j] = newMatrix[i, j];
                }
            }
            // determinant = null; determ can't change
        }
        public double? CalcDeterminant()
        {
            if (determinant.HasValue)
            {
                return determinant.Value;
            }

            if (Height != Width)
            {
                throw new InvalidOperationException("To calculate determinant matrix must be square");
            }
            determinant = 1;
            double[,] matrix = (double[,])this.matrix.Clone();
            for (int i = 0; i < Height; ++i)
            {
                bool flag = false; // всі елем які більше або дор a[i][i] ==0
                if (matrix[i, i] == 0)
                {
                    flag = true;
                    for (int j = i + 1; j < Height; ++j)
                    {
                        if (matrix[j, i] != 0)
                        {
                            determinant *= -1;
                            for (int k = 0; k < Height; ++k)
                            {
                                double temp = matrix[i, k];
                                matrix[i, k] = matrix[j, k];
                                matrix[j, k] = temp;
                                flag = false;
                            }
                        }
                        if (!flag)
                        {
                            break;
                        }
                    }
                }

                if (flag == true)
                {
                    determinant = 0;
                    break;
                }

                else
                {

                    for (int j = i + 1; j < Height; ++j)
                    {
                        //elem after diagonal but in the same col
                        double store = matrix[j, i];
                        for (int k = i; k < Height; ++k)
                        {
                            //i's row multiplied by elem divided by diagonal
                            matrix[j, k] -= matrix[i, k] * (store / matrix[i, i]);

                        }
                    }
                    determinant *= matrix[i, i];
                }
            }
            return determinant;
        }
    }
}
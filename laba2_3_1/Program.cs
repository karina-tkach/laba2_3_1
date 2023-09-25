namespace laba2_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyMatrix m1 = new MyMatrix(new string[] { "2 3 4 5,5 4","  1 5 8 3 6,8", "2 4,6 8,1 3 9" });
            //MyMatrix m2 = new MyMatrix(new string[] {"2 5,5","3 5","1 0,44","3,5 7,9","3,4 6,3" });
            //MyMatrix m3 = m1 * m2;
            //Console.WriteLine(m3);
            //MyMatrix m4 = new MyMatrix(m3.ToString());
            //Console.WriteLine(m4.GetTransposedCopy(m4));
           // MyMatrix m1 = new MyMatrix(new double[,] { { 5, 7, 1, 4 }, { 2, -3, -4, 2 }, { 3, 2, 1, 1 }, { 2, 4, 3, -1 } }); //75
           // MyMatrix m2 = new MyMatrix(new double[,] { { 2, 5, -3 }, { 1, 4, -2 }, { -7, 3, 0 } }); //-11
           // MyMatrix m3 = new MyMatrix(new double[,] { { 3, 5 }, { 4, 6 } }); //-2
            MyMatrix m4 = new MyMatrix(new double[,] { { 1, 2, 3 }, { 4, 5, 7 }, { 3, 3, 1 } }); //9
            MyMatrix m5 = new MyMatrix(new double[,] { { 2, 12, 11, 3 }, { 4, -7, 2, 5 }, { 0, 1, -2, 1 }, { -13, 2, 0, 5 } }); //4788
            MyMatrix m6 = new MyMatrix(new double[,] { { 1, 5, 3, -4 }, { 3, 1, -2, 0 }, { 5, -7, 0, 10 }, { 0, 3, -5, 0 } }); //-630
            MyMatrix m7 = new MyMatrix(new double[,] { { 16, 32, 64 }, { 8, 0, 4 }, { 0, 9, 0 } }); //4032
            MyMatrix m8 = new MyMatrix(new double[,] { { 0, 2, 6 }, { 1, 0, 4 }, { 3, 5, 0 } }); //54

            MyMatrix m9 = new MyMatrix(new double[,] { { 3, 1, 6 }, { 6, 0, 12 }, { 1, 5, 2 } }); //0

            Console.WriteLine(m9.CalcDeterminant());
        }
    }
}
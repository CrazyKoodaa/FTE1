using System;

namespace Algorithm_Star_Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region deklaration

            int row = 3, col = 5;

            #endregion deklaration

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"* ");
                }
                Console.WriteLine();
            }
        }
    }
}

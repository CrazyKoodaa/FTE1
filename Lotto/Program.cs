using System;

namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Random rand = new Random();
            int[] tippen = new int[6];
            int[] gezogen = new int[6];
            int[,] zahlenfeld = new int[50,2];
            bool istDoppelt = false;
            int gewonnen = 0;

            for (int i = 1; i <= 49; i++)
            {
                zahlenfeld[i, 0] = i;
            }
            for (int i = 0; i < 6; i++) // gezogen
            {
                int temp = rand.Next(1, 49);
                istDoppelt = checkDouble(gezogen, temp);
                if (istDoppelt)
                    i--;
                else
                {
                    gezogen[i] = temp;
                    zahlenfeld[temp,1] = 1;   
                }
            }

            for (int i = 0; i < 6; i++) // getippt
            {
                int temp = rand.Next(1, 50);
                istDoppelt = checkDouble(tippen, temp);
                if (istDoppelt)
                {
                    i--;
                }
                else
                {
                    tippen[i] = temp;
                    zahlenfeld[temp, 1] += 100;
                }
            }


            for (int i = 1; i <= 49; i++)
            {
                Console.Write($"{i,3}:{zahlenfeld[i,1],3} ");
                if (zahlenfeld[i, 1] == 101)
                    gewonnen += 1;
                if (i % 7 == 0)
                    Console.Write("\n");
            }
            Console.WriteLine($"\nDu hast {gewonnen} richtige Zahlen getippt");


        }

        static bool checkDouble(int[] array, int zahl)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (zahl == array[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}

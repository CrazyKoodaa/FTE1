using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            const int iTemperaturAnzahl = 7, iCharacterLength = 7;
            double[] daTemperatur = new double[iTemperaturAnzahl] { 4.9, 5.8, 4.8, 1.5, 0.8, -2.1, 5.0 };
            double[] daTemperaturMin = new double[iTemperaturAnzahl] { 1.2, 2, 0.2, -1.3, -3.8, -6.3, 3.2 };
            double[] daTemperaturMax = new double[iTemperaturAnzahl] { 9.7, 11.1, 8.7, 4.8, 5.0, 3.1, 7.3 };


            double[,] d2dTemperatur = //var d2dTemperatur = new double[,]
            {
                 { 1.2, 2, 0.2, -1.3, -3.8, -6.3, 3.2 },
                 { 4.9, 5.8, 4.8, 1.5, 0.8, -2.1, 5.0 },
                 { 9.7, 11.1, 8.7, 4.8, 5.0, 3.1, 7.3 }
            };

            double dTemperaturDurchschnitt = 0, dTemperaturMax = 0, dTemperaturMin = 9999999999.9;

            Console.WriteLine($"Hallo, füttere mich mit Cookies :)\n");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < iTemperaturAnzahl; j++)
                {
                    if (j == 0)
                        Console.WriteLine();

                    Console.Write($"{d2dTemperatur[i, j],iCharacterLength:F2}");
                    if (i == 1)
                    {
                        dTemperaturDurchschnitt += d2dTemperatur[i, j];
                    }
                    if (i == 2 && j == 1)
                    {
                        dTemperaturDurchschnitt /= 7;
                    }
                }

            Console.WriteLine($"\n{d2dTemperatur.Cast<double>().Max()} ist max");
            Console.WriteLine($"{d2dTemperatur.Cast<double>().Min()} ist min");
            Console.WriteLine($"{d2dTemperatur.Cast<double>().Average()} ist durchschnitt");
            Console.WriteLine($"{dTemperaturDurchschnitt} ist anderer Durchschnitt\n\n");
            dTemperaturDurchschnitt = 0;

            /*
            Console.WriteLine($"-----------------------");
            var array = new int[,]
{
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 }
};

            int count = 0;
            var averages = array.Cast<int>()
                                .GroupBy(x => count++ / array.GetLength(1))
                                .Select(g => g.Average())
                                .ToArray();
            Console.WriteLine(averages);

            Console.WriteLine($"-----------------------");

            count = 0;
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            var test = Enumerable.Range(0, rows)
            .Select(row => Enumerable
                .Range(0, cols)
                .Select(col => array[row, col])
                .Average())
            .ToArray();

            Console.WriteLine($"test = {test}");
            Console.WriteLine($"-----------------------");


            */

            /*for (int i = 0; i < iTemperaturAnzahl; i++)
            {
                Console.Write($"{i + 1}. Temperatur eingeben: ");
                
                iTemperatur[i] = Convert.ToDouble(Console.ReadLine());
            }
            */
            /*
            Console.Write($"Min. Temp:   ");
            for (int i = 0; i < iTemperaturAnzahl; i++)
            {
                Console.Write($"{daTemperaturMin[i],iCharacterLength:F2}");
            }
            Console.WriteLine();

            Console.Write($"Mittl. Temp: ");
            for (int i = 0; i < iTemperaturAnzahl; i++)
            {
                Console.Write($"{daTemperatur[i],iCharacterLength:F2}");
            }
            Console.WriteLine();

            Console.Write($"Max. Temp:   ");
            for (int i = 0; i < iTemperaturAnzahl; i++)
            {
                Console.Write($"{daTemperaturMax[i],iCharacterLength:F2}");
            }
            Console.WriteLine();
            */


            for (int i = 0; i < iTemperaturAnzahl; i++)
            {
                dTemperaturDurchschnitt += daTemperatur[i];

                if (daTemperaturMax[i] > dTemperaturMax)
                    dTemperaturMax = daTemperaturMax[i];
                if (daTemperaturMin[i] < dTemperaturMin)
                    dTemperaturMin = daTemperaturMin[i];

            }
            dTemperaturDurchschnitt /= iTemperaturAnzahl;

            Console.WriteLine($"\n\nDie min Temperatur beträgt: {dTemperaturMin:F2}");
            Console.WriteLine($"Die durchschnittliche Temperatur beträgt: {dTemperaturDurchschnitt:F2}");
            Console.WriteLine($"Die max Temperatur beträgt: {dTemperaturMax:F2}");
        }
    }
}

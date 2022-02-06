using System;

namespace zinseszins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kapitalEingabe = 0;
            Console.Write($"Bitte Startkapital eingeben: ");
            kapitalEingabe = Convert.ToInt32(Console.ReadLine());
            double kapitalTemp = kapitalEingabe;

            for (int zins = 2; zins <= 6; zins++)
            {
                for (int j = 0; j <= 5; j++)
                {

                    kapitalTemp = kapitalTemp * (1 + (zins / 100.0));
                    Console.Write($"{kapitalTemp,8:F2}\t");
                }
                Console.WriteLine();
                kapitalTemp = kapitalEingabe;

            }
        }
    }
}


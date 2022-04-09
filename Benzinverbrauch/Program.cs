using System;

namespace Benzinverbrauch
{
    class KFZ
    {
        public static double BerechneBenzinverbrauch(int gefahreneKilometer, double verbrauchteLiter) => verbrauchteLiter / gefahreneKilometer * 100;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Zahlen 1 - 6");

            var verbrauch = Console.ReadKey(true).KeyChar switch
            {
                '1' => KFZ.BerechneBenzinverbrauch(96, 4.2),
                '2' => KFZ.BerechneBenzinverbrauch(178, 10.2),
                '3' => KFZ.BerechneBenzinverbrauch(63, 7.8),
                '4' => KFZ.BerechneBenzinverbrauch(158, 20),
                '5' => KFZ.BerechneBenzinverbrauch(260, 38),
                '6' => KFZ.BerechneBenzinverbrauch(370, 50),
                _ => -1,
            };
            Console.WriteLine($"{verbrauch:F2}");
        }
    }
}

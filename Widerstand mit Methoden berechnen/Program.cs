using System;

namespace Widerstand_mit_Methoden_berechnen
{
    internal class Program
    {
        static double reihe(double r1, double r2) => r1 + r2;
        static double parallel(double r1, double r2) => r1 * r2 / (r1 + r2);

        static double gesamt() => reihe(parallel(reihe(100, 500), reihe(200, parallel(600, 300))), 600);
        static double leistungsberechnung(double volt) => volt * volt / gesamt();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"{leistungsberechnung(6):F2}");
        }
    }
}

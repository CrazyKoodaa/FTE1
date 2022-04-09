using System;

namespace Zinsberechnung_mit_Methoden
{
    class Sparkonto
    {
        
        private static double berechneZinsen(double guthaben, double zinssatz) => guthaben * (zinssatz / 100);
        public static double berechneNeuesGuthaben(double guthaben, double zinssatz) => berechneZinsen(guthaben, zinssatz) + guthaben;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Sparkonto.berechneNeuesGuthaben(1000, 2.5));
        }
    }
}

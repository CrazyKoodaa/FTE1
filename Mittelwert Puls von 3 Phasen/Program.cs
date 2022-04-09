﻿using System;
using System.Linq;

namespace Mittelwert_Puls_von_3_Phasen
{
    class Pulsklasse
    {
        public static double Mittelwert(double[] array) => array.Average();

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] puls1 = new double[] { 85, 105, 135, 162 };
            double[] puls2 = new double[] { 165, 168, 170, 175, 178, 181 };
            double[] puls3 = new double[] { 160, 115, 86 };

            double[] mittelwertPuls = new double [] { Pulsklasse.Mittelwert(puls1), Pulsklasse.Mittelwert(puls2), Pulsklasse.Mittelwert(puls3) };
            var mittelwert = Pulsklasse.Mittelwert(mittelwertPuls);
            Console.WriteLine(mittelwert);


            Console.WriteLine("Hello World!");
        }
    }
}
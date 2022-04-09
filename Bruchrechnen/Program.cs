using System;

namespace Bruchrechnen
{
    public static class Bruchrechnen
    {
        public static void addieren(int zaehler1, int nenner1, int zaehler2, int nenner2, out int summeZaehler, out int summeNenner)
        {
            summeZaehler = (zaehler1 * nenner2) + (zaehler2 * nenner1);
            summeNenner = nenner1 * nenner2;
        }
        public static void multiplizieren(int zaehler1, int nenner1, int zaehler2, int nenner2, out int summeZaehler, out int summeNenner)
        {
            summeZaehler = zaehler1 * zaehler2;
            summeNenner = nenner1 * nenner2;
        }
        public static void teilen(int zaehler1, int nenner1, int zaehler2, int nenner2, out int summeZaehler, out int summeNenner)
        {
            summeZaehler = zaehler1 * nenner2;
            summeNenner = nenner1 * zaehler2;
        }
        public static void subtrahieren(int zaehler1, int nenner1, int zaehler2, int nenner2, out int summeZaehler, out int summeNenner)
        {
            summeZaehler = (zaehler1 * nenner2) - (zaehler2 * nenner1);
            summeNenner = nenner1 * nenner2;
        }

        //public static void kuerzen(int summeZaehler, int summeNenner, out int summeZaehlerKuerzt, out int summeNennerKuerzt)
        public static (int, int) kuerzen(int summeZaehler, int summeNenner)
        {
            // suche nach dem größtem gemeinsamen Teiler
            // 27/81, da steckt die 3, 9 und 27 drin!!
            int summeZaehlerKuerzt = 0;
            int summeNennerKuerzt = 0;

            if (summeZaehler < summeNenner)
            {
                for (int i = summeZaehler; i >= 2; i++)
                {
                    if (summeZaehler % summeZaehler == 0 && summeNenner % summeZaehler == 0)
                    {
                        summeZaehlerKuerzt = summeZaehler / summeZaehler;
                        summeNennerKuerzt = summeNenner / summeZaehler;
                        return (summeZaehler, summeNenner);
                    }
                }
            }
            else
            {
                for (int i = summeNenner; i >= 2; i++)
                {
                    if (summeZaehler % summeZaehler == 0 && summeNenner % summeZaehler == 0)
                    {
                        summeZaehlerKuerzt = summeZaehler / summeZaehler;
                        summeNennerKuerzt = summeNenner / summeZaehler;
                        return (summeZaehler, summeNenner);

                    }
                }
            }
            return (0,0);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] zahlen;
            int summeZaehler = 0, summeNenner = 0, summeZaehlerKuerzt = 0, summeNennerKuerzt = 0;


            Console.WriteLine($"Biite Zahlen eingeben im Format (Mit Leerzeichen da zwischen):\nzahl nenner + zahl nenner");
            zahlen = Console.ReadLine().Split(' ');
            int zaehler1 = int.Parse(zahlen[0]);
            int nenner1 = int.Parse(zahlen[1]);
            int zaehler2 = int.Parse(zahlen[3]);
            int nenner2 = int.Parse(zahlen[4]);

            Console.Write("Die beiden Brüche werden ");
            switch (zahlen[2])
            {
                case "+":
                    Bruchrechnen.addieren(zaehler1, nenner1, zaehler2, nenner2, out summeZaehler, out summeNenner);
                    Console.Write("addiert:\n");
                    break;
                case "-":
                    Bruchrechnen.subtrahieren(zaehler1, nenner1, zaehler2, nenner2, out summeZaehler, out summeNenner);
                    Console.Write("subtrahiert:\n");
                    break;
                case "*":
                    Bruchrechnen.multiplizieren(zaehler1, nenner1, zaehler2, nenner2, out summeZaehler, out summeNenner);
                    Console.Write("multipliziert:\n");
                    break;
                case "/":
                    Bruchrechnen.teilen(zaehler1, nenner1, zaehler2, nenner2, out summeZaehler, out summeNenner);
                    Console.Write("teilen:\n");
                    break;
                default:
                    Console.WriteLine("Konnte kein Operator finden!");
                    break;

            }

            Console.WriteLine($"Ergebnis: {summeZaehler}/{summeNenner}");
            Console.WriteLine($"Oder als Dezimal: {(float)summeZaehler / (float)summeNenner:F3}");
            (int, int) summeZaehlerGekuerzt = Bruchrechnen.kuerzen(summeZaehler, summeNenner);
            Console.WriteLine($"oder gekürzt: {summeZaehlerGekuerzt.Item1}/{summeZaehlerGekuerzt.Item2}");


            
        }
    }
}

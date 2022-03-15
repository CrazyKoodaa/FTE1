using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_Shop
{
    static class Shop
    {
        public static void kaufen( int nummer, double preis, int anzahl)
        {
            Console.WriteLine("Der Artikel mit der Artikelnummer: {0}", nummer);
            Console.WriteLine("kostet {0:F2} Euro!", preis);
            
            Console.WriteLine($"Gesamtpreis für {anzahl} ist {(anzahl * preis):c}");
            Console.WriteLine();
        }

        public static void kaufen(int nummer, double preis)
        {
            Console.WriteLine("Der Artikel mit der Artikelnummer: {0}", nummer);
            Console.WriteLine("kostet {0:F2} Euro!", preis);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int artikel1_nr = 123;
            double artikel1_preis = 19.90;
            int artikel2_nr = 456;
            double artikel2_preis = 14.70;

            Console.WriteLine("Programm Shopping\n");
            Console.WriteLine("Bitte Anzahl eingeben: ");
            int anzahlArtikel1 = Convert.ToInt32(Console.ReadLine());

            
            Shop.kaufen(artikel1_nr, artikel1_preis);
            Shop.kaufen(artikel2_nr, artikel2_preis, anzahlArtikel1);
            //Shop.kaufen(artikel2_nr, artikel2_preis);

            Console.ReadKey();
        }
    }

}

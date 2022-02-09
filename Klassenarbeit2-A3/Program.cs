using System;

namespace Klassenarbeit2_A3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dauer = 0, i, k = 0;
            double betrag, zinssatz = 0.0;
            char tarif;
            Console.WriteLine("Anlagebetrag? ");
            betrag = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tarif? ");
            tarif = Convert.ToChar(Console.ReadLine());
            switch (tarif)
            {
                case 'A': zinssatz = 0.2; dauer = 3; break;
                case 'B': zinssatz = 0.5; dauer = 5; break;
                case 'C': zinssatz = 1.0; dauer = 10; break;
                case 'D': zinssatz = 2.0; dauer = 15; break;

            }
            for (i = 1; i <= dauer; i++)
            {
                betrag = betrag * (1 + zinssatz / 100);
                Console.WriteLine($"{i,2}. Jahr: {betrag,9:F2} Euro");
                if (k == 0 && betrag >= 10000)
                    k = i;
            }
            if (k > 0 && k < dauer)
                Console.WriteLine($"Kündigung ist möglich nach {k} Jahr(en).");
            else
                Console.WriteLine("Kündigung ist nicht möglich.");
        }
    }
}

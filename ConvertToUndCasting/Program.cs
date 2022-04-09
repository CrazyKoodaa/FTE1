using System;

namespace ConvertToUndCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int zahl1 = 66, zahl2 = 65535, erg_int;
            char zeichen1 = 'A', erg_zeichen;
            double kommazahl1 = 5.123, kommazahl2 = 2.945, erg_double;

            Console.WriteLine($"k1 in int32 {Convert.ToInt32(kommazahl1)}");
            Console.WriteLine($"k1 mit cast {(int)kommazahl1}");
            Console.WriteLine();
            Console.WriteLine($"k2 in int32 {Convert.ToInt32(kommazahl2)}");
            Console.WriteLine($"k2 mit cast {(int)kommazahl2}");
            Console.WriteLine();
            Console.WriteLine($"z1 in double {Convert.ToDouble(zahl1)}");
            Console.WriteLine($"z1 mit cast {(double)zahl1}");
            Console.WriteLine();
            Console.WriteLine($"c1 in int32 {Convert.ToInt32(zeichen1)}");
            Console.WriteLine($"c1 mit cast {(int)zeichen1}");
            Console.WriteLine();
            Console.WriteLine($"z2 in char {Convert.ToChar(zahl2)}");
            Console.WriteLine($"z2 mit cast {(char)zahl2}");
            //Console.WriteLine($"z2 neu in char {Convert.ToChar(65536)}");
            //Console.WriteLine($"z2 neu cast {(char)65536}");




        }
    }
}

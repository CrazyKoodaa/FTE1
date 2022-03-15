using System;

// Namespace sollte mit einer großen Buchstabe anfangen
namespace statischeMethodenInCSharp
{
    // Class sollte mit einer großen Buchstabe anfangen
    // static bedeutet die Klasse erlaubt nur statische Methoden

    public static class Methodensammlung
    {
        // Methodenname sollte mit einem Verb anfangen (erster Buchstabe klein)
        // die Methode wird vom Klassennamen aufgerufen.
        // public = "Öffentlich" sie kann auch von anderen Klassen aufgerufen werden
        // void vor Methodenname bedeutet kein Rückgabewert
        
        
        // ist random.next() eine statische Methode??

        public static void schreibeHallo()
        {
            Console.WriteLine($"Hallo");
            
        }

        public static void schreibeMainProgram()
        {
            Console.WriteLine(" Main Program :)");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console = Klasse
             * WriteLine() = Methode (deswegen auch die Klammern)
             * "Hello..." = Parametern (arguments)
             * 
             * return = Wert zurück geben aus der Methode
             */

            Console.WriteLine("Hello statische Methoden!");
            Methodensammlung.schreibeHallo();
            statischeMethodenInCSharp.Methodensammlung.schreibeHallo();
            Methodensammlung.schreibeMainProgram();

            Console.WriteLine();
        }
    }
}

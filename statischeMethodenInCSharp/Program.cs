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
        
        
        // ist random.next() eine statische Methode?? Nein, es ist ein Object was zuerst erstellt werden muss und dann kann man mit dem Objekt die Methode next() aufrufen

        public static void schreibeHallo()
        {
            Console.WriteLine($"Hallo");
        }

        public static void schreibeMainProgram()
        {
            Console.WriteLine(" Main Program :)");
        }

    }
    static class Mathe
    {
        // (int zahl) = Parameter (Übergabewert, der an die Methode übergeben wird)
        // zuerst den Datentyp des Parameters schreiben, dann den Variablenname die es intern verwenden soll.
        // return ergebnis = gebe das ergebnis an die aufgerufene Methodenaufruf zurück
        public static int quadriere(int zahl)
        {
            //Lokale Variablen der Methode sind nur innerhalb der {} also Methode bekannt und gültig. Sobald die Methode vorbei ist, wird auch die lokale Variable gelöscht:
            int ergebnis;
            ergebnis = zahl * zahl;
            return ergebnis;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // const = dieser Variable wird nur einmal deklariert und kann nicht mehr irgendwo verändert werden.
            // diese Variable kann auch nur hier in der Methode Main verwendet werden
            const int QUADRIEREZAHL = 5;
            Console.WriteLine(Mathe.quadriere(QUADRIEREZAHL));
            Console.WriteLine();

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


        }
    }
}

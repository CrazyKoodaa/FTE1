using System;
using System.Linq;

namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            string temp = "tsest";
            string palin = new string(temp.Reverse().ToArray());
            if (temp == palin)
                Console.WriteLine("Ist Palin");
            else
                Console.WriteLine("Nicht Palin");
        }
    }
}

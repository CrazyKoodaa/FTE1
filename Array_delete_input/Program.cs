using System;
using System.Collections.Generic;
using System.Linq;


namespace Array_delete_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = { 1, 3, 4, 9, 2 };

            var numbersList = numbers.ToList(); //convert array to list

            //remove and add
            numbersList.Remove(4);
            numbersList.Add(9);

            numbersList.Sort(); //sort list
            numbersList.RemoveAll(x => x == 9); //remove all 9
            int[] number = numbersList.ToArray(); //convert back to array


            // output array
            for (int i = 0; i < number.Length; i++)
                Console.WriteLine(number[i]);
        }
    }
}

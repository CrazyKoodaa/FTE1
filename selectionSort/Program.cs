using System;

namespace selectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] selectionSort = new int[5] { 1, 8, 6, 7, 9 };
            int merker = 0, merkerZahl;
            bool tauschen = false;

            for (int i = 0; i < selectionSort.Length; i++)
            {
                merkerZahl = selectionSort[i];
                for (int x = i; x < selectionSort.Length; x++)
                {
                    if (merkerZahl > selectionSort[x])
                    {
                        merkerZahl = selectionSort[x];
                        merker = x;
                        tauschen = true;
                    }
                }

                if (tauschen == true)
                {
                    int temp = selectionSort[i];
                    selectionSort[i] = selectionSort[merker];
                    selectionSort[merker] = temp;
                    tauschen = false;
                    
                }

                
            }
            for (int i = 0; i < selectionSort.Length; i++)
            {
                Console.WriteLine(selectionSort[i]);
            };
        }
    }
}

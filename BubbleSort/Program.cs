using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] bubbleSort = new int[5] { 4, 2, 6, 7, 1};

            for (int x = 0; x < bubbleSort.Length; x++)
            { 
                for (int i = 0; i < bubbleSort.Length - 1; i++)
                {
                    if (bubbleSort[i] > bubbleSort[i + 1])
                    {
                        int temp = bubbleSort[i];
                        bubbleSort[i] = bubbleSort[i + 1];
                        bubbleSort[i + 1] = temp;
                    }

                }
            }

            for (int i = 0; i < bubbleSort.Length; i++)
            {
                Console.WriteLine(bubbleSort[i]);
            };

        }
    }
}

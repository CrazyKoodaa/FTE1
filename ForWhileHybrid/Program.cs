using System;

namespace ForWhileHybird
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region deklaration
            int stop = 0;
            #endregion deklaration

            for (int i = 0; stop != 1; i++)
            {
                if (i == 6)
                {
                    stop = 1;
                    Console.WriteLine($"stopping at 6");
                }
            }

        }
    }
}

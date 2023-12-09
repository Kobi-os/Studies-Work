using System;

namespace Zad4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, k;
            for (w = 1; w <= 10; w++)
            {
                for (k = 1; k <= 10; k++)
                  if (w == k | w + k == 11 | (w >= 4 & w <= 7 & k >= 4 & k <= 7))  
                         Console.Write(" * ");
                else
                        Console.Write("   ");
                Console.WriteLine();
            }
        }
    }
}



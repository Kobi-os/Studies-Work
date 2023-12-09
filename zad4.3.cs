using System;

namespace Zadanie_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int w;
            Console.WriteLine("Wprowadz liczba wierszy (od 9 do 15 nieparzystą)");
            w = Convert.ToInt32(Console.ReadLine());
            int i, j;
            for( i = 1; i <= w; i++)
            {
                for (j = 1; j <= w; j++)
                    if (i == 1 | i == w | j == 1 | j == w | i==(w-1)/2+1 | j == (w - 1) / 2 + 1)
                        Console.Write(" * ");
                    else
                        Console.Write("   ");
                Console.Write("\n");
            }

        }
    }
}



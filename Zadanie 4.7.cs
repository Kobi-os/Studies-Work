using System;

namespace Zadanie_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 11;
            int height = 5;

            for (int h = 0; h <= height; h++)
            {
                for (int w = 0; w <= width; w++)
                {
                    if (h == w || h + w == width - 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

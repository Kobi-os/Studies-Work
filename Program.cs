using System;

namespace Zadanie_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] tablica = new int[3, 5]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13 ,14 , 15}
            };

            Console.WriteLine("Tablica 3x5");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write(tablica[row, col] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Transpozycja Tablicy na Tablice 5x3");
            for (int col = 0; col < 5; col++)
            {
                for (int row = 0; row < 3; row++)
                {
                    Console.Write(tablica[row, col] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}

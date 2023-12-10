using System;

namespace Zadanie_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica = new int[5, 5];
            Random randomNumber = new Random();

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    tablica[row, col] = randomNumber.Next(10);
                }
            }

            Console.WriteLine("Tablica 5x5");

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    Console.Write(tablica[row, col] + " ");
                }
                Console.WriteLine();
            }

            int pierwszaPrzekątna = 0;
            for (int i = 0; i < 5; i++)
            {
                pierwszaPrzekątna += tablica[i, i];
            }

            int drugaPrzekątna = 0;
            for (int i = 0; i < 5; i++)
            {
                drugaPrzekątna += tablica[i, 4 - i];
            }


            Console.WriteLine($"Pierwsza przekątna {pierwszaPrzekątna}");
            Console.WriteLine($"Druga przekątna {drugaPrzekątna}");



        }
    }
}

using System;

namespace Zadanie_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[30];

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = i + 1;
            }

            int suma = 0;

            foreach (int num in tablica)
            {
                suma += num;
            }

            double srednia = (double)suma / tablica.Length;

            Console.WriteLine("tablica elementów");

            foreach (int num in tablica)
            {
                Console.WriteLine(num + " ");
            }

            Console.WriteLine($"\n Średnia wartosc elementów tablicy: {srednia}");
        }
    }
}

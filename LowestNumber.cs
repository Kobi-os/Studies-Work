using System;

namespace Zadanie_5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] tablica = { 10, 5, 2, 7, 1, 8, 4, 3, 6, 9 };
            byte najmniejszaLiczba = tablica[0];

            int pozycjaLiczby = 0;

            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] < najmniejszaLiczba)
                {
                    najmniejszaLiczba = tablica[i];
                    pozycjaLiczby = i;
                }
            }

            Console.WriteLine("Najmniejszy element tablicy: " + najmniejszaLiczba);
            Console.WriteLine("Pozycja elementu: " + pozycjaLiczby);

        }
    }
}

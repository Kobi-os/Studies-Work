using System;

namespace Zadanie_3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę naturalną ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            int dzielnik = 1;
            Console.WriteLine("Dzielniki Liczby {0} : ", liczba);

            do
            {
                if (liczba % dzielnik == 0)
                {
                    Console.WriteLine(dzielnik);
                }
                dzielnik++;
            } while (dzielnik <= liczba);

        }
    }
}

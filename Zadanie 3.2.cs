using System;

namespace Zadanie_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe która będzie pod n");
            int n = int.Parse(Console.ReadLine());
            int sumaLiczb = 0;
            int i = 1;

            while ( i <= n)
            {
                sumaLiczb += i;
                i++;
            }
            Console.WriteLine($"Suma liczb wynosi {sumaLiczb}");
        }
    }
}

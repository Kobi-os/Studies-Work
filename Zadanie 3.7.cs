using System;

namespace Zadanie_3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b ");
            int b = Convert.ToInt32(Console.ReadLine());

            int wynik = 1;
            int i = 0;

            while (i < b)
            {
                wynik *= a;
                i++;
            }

            Console.WriteLine($"Wynik: {wynik}");
        }
    }
}

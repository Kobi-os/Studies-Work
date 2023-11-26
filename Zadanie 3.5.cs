using System;

namespace Zadanie_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lokata = 10000m;
            decimal oprocentowanie = 0.05m;
            decimal odsetki = 0;
            int liczbaMiesiecy = 12;

            for (int i = 0; i < liczbaMiesiecy; i++)
            {
                decimal odsetkiMiesieczne = (lokata * oprocentowanie) / 12;
                odsetki += odsetkiMiesieczne;
                lokata += odsetkiMiesieczne;
            }

            Console.WriteLine($"Odestki {odsetki}");
            Console.WriteLine($"Kwota końcowa {lokata}");
            Console.WriteLine($"wynik {odsetki:C} ");

        }
    }
}

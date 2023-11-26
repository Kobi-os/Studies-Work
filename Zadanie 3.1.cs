using System;

namespace Zadanie_3._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int ilośćLiczb = 0;
            int sumaLiczb = 0;

            while (sumaLiczb <= 100)
            {
                Console.Write("Podaj Liczbę;");
                int liczba = int.Parse(Console.ReadLine());

                sumaLiczb += liczba;
                ilośćLiczb += 1;

                Console.WriteLine("Suma liczba wynosi: " + sumaLiczb);
                Console.WriteLine("Dodaleś : " + ilośćLiczb);
            }
        }
    }
}

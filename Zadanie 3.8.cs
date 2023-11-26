using System;

namespace Zadanie_3._8
{
    class Program
    {
        static void Main(string[] args)
        {

            double x;
            do
            {
                Console.WriteLine("Podaj Liczbe");
                string userNumber = Console.ReadLine();

                if (double.TryParse(userNumber, out x))
                {
                    if (Math.Abs(x) > 2 && Math.Abs(x) < 3)
                    {
                        Console.WriteLine("Liczba {0} spelnia warunek 2<|x|<3", x);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Liczba {0} nie spełnia warunku 2<|x|<3", x);
                    }
                }
                else
                {
                    Console.WriteLine("Nieprawidłowe dane, Podaj Liczbe ");
                }
            } while (true);
        }
    }
}

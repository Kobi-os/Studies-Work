using System;

namespace Zadanie_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIterations = 100;
            double sum = 0;

            for (int n = 0; n <= numberOfIterations; n++)
            {
                double term = Math.Pow(-1, n) / (2 * n + 1);
                sum += term;
            }

            double result = sum * 4;

            Console.WriteLine($"Przybliżona wartość pi to: " + result);
        }
    }
}

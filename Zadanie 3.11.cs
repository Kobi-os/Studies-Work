using System;

namespace Zadanie_3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            double start = -1.0;
            double koniec = 5.0;
            double dokładność = 0.05;

            for (double x = start; x <= koniec; x += dokładność)
            {
                double prevX = x - dokładność;
                double nextX = x + dokładność;

                double prevY = Math.Pow(prevX, 3) - 5 * Math.Pow(prevX, 2) + 3 * prevX + 3;
                double currentY = Math.Pow(x, 3) - 5 * Math.Pow(x, 2) + 3 * x + 3;
                double nextY = Math.Pow(nextX, 3) - 5 * Math.Pow(nextX, 2) + 3 * nextX + 3;

                if (currentY > prevY && currentY > nextY)
                {
                    Console.WriteLine($"Maksimum lokalne: x={x}, f(x) = {currentY}");
                }
                else if (currentY < prevY && currentY < nextY)
                {
                    Console.WriteLine($"Minimum lokalne x={x}, f(x)={currentY}");
                }
            }
        }
    }
}

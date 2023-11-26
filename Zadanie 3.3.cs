using System;

namespace Zadanie_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 7;
            int numberOfNumbers = 0;
            int sumOfNumbers = 0;
  

            do
            {
                numberOfNumbers++;
                sumOfNumbers += numberOfNumbers;
            } while (sumOfNumbers < value); 

            Console.WriteLine($"Suma liczb do dodania {numberOfNumbers}");

        }
    }
}

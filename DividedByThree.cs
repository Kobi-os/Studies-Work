namespace DividedByThree
{
    internal class DividedByThree
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Liczbe w przedziale od 1 do 999");
            int number = Convert.ToInt32(Console.ReadLine());

            int setki = number / 100;
            number -= setki * 100;
            int dziesiatki = number / 10;
            number -= dziesiatki * 10;

            int jednosci = number;

            int SumOfNumbers = setki + dziesiatki + jednosci;

            if (SumOfNumbers % 3 == 0)
            {
                Console.WriteLine("Liczbe jest podzielna przez 3");
            } else
            {
                Console.WriteLine("Liczba nie jest podzielna przez 3");
            }
        }
    }
}
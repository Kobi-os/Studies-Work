namespace SwitchInstruction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbe całkowitą dodatnia ");
            double numberOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbe całkowitą dodatnia ");
            double numberTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wybierz operacje arytmetyczną +, -, /, * ");

            char operation = Convert.ToChar(Console.ReadLine());

            double wynik;
            switch (operation)
            {
                case '+':
                    wynik = numberOne + numberTwo;
                    Console.WriteLine("Wynik Dodawania " +  wynik);
                    break;

                case '-':
                    wynik = numberOne - numberTwo;
                    Console.WriteLine("Wynik odejmowania " + wynik);
                    break;

                case '/':
                    wynik = numberOne / numberTwo;
                    Console.WriteLine("Wynik Dzielenia " + wynik);
                    break;

                case '*':
                    wynik = numberOne * numberTwo;
                    Console.WriteLine("Wynik mnożenia " + wynik);
                    break;
            }
        }
    }
}
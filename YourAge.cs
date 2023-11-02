namespace YourAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Swój Wiek");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Jestes niepełnoletni brak dostępu");
            } 
            else
            {
                Console.WriteLine("Jestes Pełnoletni możesz wejsc");
            }
        }
    }
}
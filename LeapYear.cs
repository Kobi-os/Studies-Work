namespace LeapYear
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Podaj Rok: ");
            
            int rok = int.Parse(Console.ReadLine());
           

           if (yearLeap(rok))
            {
                Console.WriteLine($"{rok} jest przestępny");
            } else
            {
                Console.WriteLine($"{rok} nie jest przestępny");
            }
        }

         static bool yearLeap( int rok )
        {
            return (rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0);
        }
    }
}
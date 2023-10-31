namespace AgeRestriction
{
    internal class AgeRestriction
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj Wiek");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && age <= 30)
            {
                switch (age)
                {
                    case 18:
                        Console.WriteLine("Jestes pełnoletni");
                        break;

                    case 19:
                    case 20:
                    case 21:
                    case 22:
                    case 23:
                    case 24:
                    case 25:
                        Console.WriteLine("Jestes w przedziale wiekowym od 19 do 25");
                        break;

                    default:
                        Console.WriteLine("Masz ponad 25 lat ale jestes jeszcze przed 30");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Jestes poza przedziałem wiekowym 18-30");

            }


        }
    }
}
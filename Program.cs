class Program
{
    static void Main()
    {
        double a, b;

        a = Math.Pow(Math.Sqrt(2), 3);
        b = Math.Pow(3, Math.Sqrt(2));

        if (a > b)
        {
            Console.WriteLine("Pierwiastek z dwóch jest większy niż pierwiastek z 3");
        } else
        {
            Console.WriteLine("Pierwiastek z 3 jest większy niż pierwiastek z 2");
        }

    }
}



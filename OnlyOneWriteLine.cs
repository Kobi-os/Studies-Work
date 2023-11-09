using System;

namespace OnlyOneWriteLine
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            int a, b, c;

            Console.WriteLine("Podaj a");
            a = int.Parse(Console.ReadLine());


            Console.WriteLine("Podaj b");
            b = int.Parse(Console.ReadLine());


            Console.WriteLine("Podaj c");
            c = int.Parse(Console.ReadLine());



            int tmp;

            if (a > b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }
            if (b > c)
            {
                tmp = b;    
                b = c;
                c = tmp;
            }
            if (a > b)
            {
                tmp = a;
                a = b;
                b = tmp;
            }

            Console.WriteLine(a + "\t" + b + "\t" + c);

        }
    }
}
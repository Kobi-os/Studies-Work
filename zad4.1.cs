using System;

namespace Zadanie_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba_kombinacji = 0;

            for(int i =0; i <= 10; i++)
            {
                for(int j = 0; j <= 5; j++)
                {
                    for(int k = 0; k <= 2; k++)
                    {
                        if(i + j * 2 + k * 5 == 10)
                        {
                            Console.WriteLine("kombinacja: {0}, złotówek, {1} dwuzlotówek, {2} pięciozłotówek", i, j, k);
                            liczba_kombinacji++;
                        }
                    }
                }
            }
        }
    }
}

using System;

namespace Zadanie_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy");
            int rozmiarTablicy = 0;
            bool userValidInput = false;

            while (!userValidInput)
            {
                try
                {
                    rozmiarTablicy = int.Parse(Console.ReadLine());
                    userValidInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowy format danych. Podaj liczbe całkowitą");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Podana wartość jest zbyt duża lub zbyt mała.");
                } 
                catch (Exception)
                {
                    Console.WriteLine("Wystąpił nieoczekiwany błąd");
                }
            }

            int[] tablica = new int[rozmiarTablicy];

            for (int i = 0; i < rozmiarTablicy; i++)
            {
                Console.Write($"Podaj wartość dla elementu: {i}: ");
                userValidInput = false;

                while (!userValidInput)
                {
                    try
                    {
                        tablica[i] = int.Parse(Console.ReadLine());
                        userValidInput = true;
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("Nieprawidłowy format danych. Podaj liczbe całkowitą");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Podana wartość jest zbyt duża lub zbyt mała.");
                    }
                    catch(Exception)
                    {
                    Console.WriteLine("Wystąpił nieoczekiwany błąd");
                    }
                }
            }

                Console.WriteLine("Zawartość tablicy:");

                for (int i = 0; i < rozmiarTablicy; i++) {
                    Console.WriteLine($"Element {i}; {tablica[i]}");
                }
            
        }
    }
}

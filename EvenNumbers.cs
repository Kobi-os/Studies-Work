


namespace EvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> {20, 1, 4 };

            list.Sort();

            foreach (var number in list) 
            {
                Console.WriteLine(number);
            }

        }
    }
}
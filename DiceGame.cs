namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int PlayerNumberOne;
            int EnemyPlayer;

            int PlayerScore = 0;
            int EnemyScore = 0;

            Random number = new Random();

            for (int i = 0; i < 5; i++)
            {

                Console.ReadKey();
                PlayerNumberOne = number.Next(1, 7);
                Console.WriteLine("Player Number One numbers " + PlayerNumberOne);

                Console.WriteLine("Next Player");
                Thread.Sleep(1000);
                

                EnemyPlayer = number.Next(1, 7);
                Console.WriteLine("Enemy Player numbers " + EnemyPlayer);
                

                if (PlayerNumberOne > EnemyPlayer)
                {
                    PlayerScore++;
                    Console.WriteLine("Player got a point" + PlayerScore);
                } 
                else if (EnemyPlayer > PlayerScore)
                {
                    EnemyScore++;
                    Console.WriteLine("Enemy got a point" + EnemyScore);
                }
                else
                {
                    Console.WriteLine("Nobody gets a point the numbers are the same");
                }
            }
        }
    }
}
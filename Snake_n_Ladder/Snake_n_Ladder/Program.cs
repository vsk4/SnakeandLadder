using System;
namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            const int playerOne = 1;
            int positionOne = 0;
            Random random = new Random();
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("Die Rolls: " + dieRoll);
        }
    }
}
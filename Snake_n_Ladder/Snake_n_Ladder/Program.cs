using System;
namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            const int noPlayOption = 0;
            const int ladderOption = 1;
            const int snakeOption = 2;
            int player = 0;
            int[] playerPosition = new int[2] { 0, 0 };
            int diceRollCount = 0;
            while (playerPosition[player] < 100)
            {
                Random random = new Random();
                int dieRoll = random.Next(1, 7);
                diceRollCount++;
                int options = random.Next(0, 3);
                switch (options)
                {
                    case noPlayOption:
                        Console.WriteLine("Player " + player + "Position: " + playerPosition[player]);
                        break;
                    case ladderOption:
                        if (playerPosition[player] + dieRoll <= 100)
                        {
                            playerPosition[player] = playerPosition[player] + dieRoll;
                        }
                        Console.WriteLine("Player " + player + "Position: " + playerPosition[player]);
                        break;
                    case snakeOption:
                        playerPosition[player] = playerPosition[player] - dieRoll;
                        if (playerPosition[player] < 0)
                        {
                            playerPosition[player] = 0;
                        }
                        Console.WriteLine("Player " + player + " Position: " + playerPosition[player]);
                        break;
                }
                if (options == noPlayOption || options == snakeOption)
                {
                    if (player == 0)
                    {
                        player = 1;
                    }
                    else
                    {
                        player = 0;
                    }
                }
            }
            Console.WriteLine("Player " + player + " Wins with Die Roll :" + diceRollCount);
        }
    }
}
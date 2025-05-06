using System.Collections.Generic;
using BlackJack;

namespace BlackJack.GameLogics
{
    public class GameLogic
    {
        int PlayerCount { get; set; }
        public static List<Player> Players = new List<Player>();
        public static int PlayerScore { get; set; }

        public static void StartGame(int PlayerCount)
        {
            for (int i = 0; i < PlayerCount; i++)
            {
                PlayerScore = RandomNumberGenerator.GenerateRandomNumber() + RandomNumberGenerator.GenerateRandomNumber();
                Console.WriteLine($"Player {i + 1} score is {PlayerScore}");
                while (true)
                {
                    Console.WriteLine("Do you want to hit or stay? (h/s)");
                    string userInput = Console.ReadLine();
                    if (userInput == "h")
                    {
                        PlayerScore += RandomNumberGenerator.GenerateRandomNumber();
                        
                        Console.WriteLine($"Player {i + 1} score is {PlayerScore}");
                        if (PlayerScore > 21)
                        {
                            Console.WriteLine($"Player {i + 1} busted with a score of {PlayerScore}");
                            break;
                        }
                    }
                    else if (userInput == "s")
                    {
                        Console.WriteLine($"Player {i + 1} chose to stand with a score of {PlayerScore}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'h' to hit or 's' to stay.");
                    }
                }
                Players.Add(new Player(i + 1) { Score = PlayerScore });
            }
            for(int i = 0;i<PlayerCount;i++)
                    {
                        if (Players[i].Score==21)
                        {
                            Console.WriteLine($"Player {Players[i].id} wins with a score of {Players[i].Score}!");
                        }
                        else if (Players[i].Score > 21)
                        {
                            Console.WriteLine($"Player {Players[i].id} busted with a score of {Players[i].Score}");
                        }
                        else
                        {
                            Console.WriteLine($"Player {Players[i].id} stands with a score of {Players[i].Score}");
                        }
                    }
        }
    }
}
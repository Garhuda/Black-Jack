using BlackJack.GameLogics;
namespace BlackJack
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BlackJack!");
            Console.WriteLine("How many players are playing? (1-4)");
            int playerCount = int.Parse(Console.ReadLine());
            
            GameLogic.StartGame(playerCount);
        }
    }
}



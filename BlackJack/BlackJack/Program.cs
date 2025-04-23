namespace BlackJack
{
    class Program
    {


        public static void Main(string[] args)

        {
            int playerScore = RandomNumberGenerator.GenerateRandomNumber() + RandomNumberGenerator.GenerateRandomNumber();
            int dealerScore = RandomNumberGenerator.GenerateRandomNumber() + RandomNumberGenerator.GenerateRandomNumber();
            Console.WriteLine("Welcome to BlackJack!");
            Console.WriteLine("Enter the word exit to exit the game.");
            while (true)
            {
                // Initial card draws for both player and dealer


                Console.WriteLine("Your hand: " + playerScore);
                Console.WriteLine("Dealer's hand: " + dealerScore);
                Console.WriteLine("Enter S to stand or H to hit or exit to exit: ");

                string playerChoice = Console.ReadLine();
                if (playerChoice.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting program...");
                    break;  // Exit the program if user types "exit"
                }

                string hit = "h";
                string stand = "s";

                // If player hits
                if (playerChoice.ToLower() == hit)
                {
                    playerScore += RandomNumberGenerator.GenerateRandomNumber();
                    dealerScore += RandomNumberGenerator.GenerateRandomNumber();
                }
                // If player stands
                else if (playerChoice.ToLower() == stand)
                {
                    Console.WriteLine("Your hand: " + playerScore);  // Display updated player score
                    Console.WriteLine("Dealer's hand: " + dealerScore);  // Dealer's hand does not change
                    playerScore = 0;
                    dealerScore = 0;
                    Console.WriteLine("You chose to stand with: " + playerScore);
                    continue;
                }
                if (playerChoice == stand || dealerScore > 21 || playerScore > 21)
                {
                    if (playerScore > dealerScore && playerScore <= 21)
                    {
                        Console.WriteLine("Your hand: " + playerScore);  // Display updated player score
                        Console.WriteLine("Dealer's hand: " + dealerScore);  // Dealer's hand does not change
                        playerScore = 0;
                        dealerScore = 0;
                        Console.WriteLine("You win!");
                        continue;
                    }
                    else if (playerScore == dealerScore)
                    {
                        Console.WriteLine("Your hand: " + playerScore);  // Display updated player score
                        Console.WriteLine("Dealer's hand: " + dealerScore);  // Dealer's hand does not change
                        playerScore = 0;
                        dealerScore = 0;
                        Console.WriteLine("It's a tie!");
                        continue;
                    }
                    else if (playerScore > 21)
                    {
                        Console.WriteLine("Your hand: " + playerScore);  // Display updated player score
                        Console.WriteLine("Dealer's hand: " + dealerScore);  // Dealer's hand does not change
                        playerScore = 0;
                        dealerScore = 0;
                        Console.WriteLine("You lose! You busted.");
                        continue;
                    }
                    else if (dealerScore > 21)
                    {
                        Console.WriteLine("Your hand: " + playerScore);  // Display updated player score
                        Console.WriteLine("Dealer's hand: " + dealerScore);  // Dealer's hand does not change
                        playerScore = 0;
                        dealerScore = 0;
                        Console.WriteLine("Dealer busted! You win!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Your hand: " + playerScore);  // Display updated player score
                        Console.WriteLine("Dealer's hand: " + dealerScore);  // Dealer's hand does not change
                        playerScore = 0;
                        dealerScore = 0;
                        Console.WriteLine("You lose! Dealer wins.");
                        continue;
                    }
                }
            }
        }
    }
}



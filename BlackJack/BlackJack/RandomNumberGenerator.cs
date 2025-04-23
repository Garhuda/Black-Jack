public class RandomNumberGenerator
        {
            private static Random random = new Random();

            public static int GenerateRandomNumber()
            {
                return random.Next(1, 11); // Generates a random number between 1 and 11 to simulate cards
            }
        }
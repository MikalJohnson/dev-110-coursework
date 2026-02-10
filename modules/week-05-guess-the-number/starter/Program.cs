namespace GuessTheNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Guess the Number: Loop Trio ===\n");

        // TODO 2: Get a valid max value (10-100)
        int maxValue = ReadIntInRange(
            "Enter a max value (10-100): ",
            10,
            100
        );

        // TODO 3: Get a valid number of rounds (1-3)
        int rounds = ReadIntInRange(
            "How many rounds? (1-3): ",
            1,
            3
        );

        // TODO 4: Use a for loop to repeat the game for each round
        for (int round = 1; round <= rounds; round++)
        {
            // TODO 5: Display the round header
            Console.WriteLine($"\nRound {round} of {rounds}");

            // TODO 6: Generate a secret number
            Random random = new Random(maxValue + round);
            int secret = random.Next(1, maxValue + 1);

            // TODO 7: Initialize guess tracking variables
            int guess = 0;
            int guessCount = 0;

            // TODO 8: Use a while loop to keep asking until correct
            while (guess != secret)
            {
                // TODO 9: Read and validate a guess
                Console.Write($"Guess a number (1-{maxValue}): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    continue;
                }

                guessCount++;

                // TODO 10: Provide feedback
                if (guess < secret)
                {
                    Console.WriteLine("Too low.");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Too high.");
                }
                else
                {
                    Console.WriteLine($"Correct! You got it in {guessCount} guesses.");
                }
            }
        }

        // TODO 11: Closing message
        Console.WriteLine("\nThanks for playing!");
    }

    // TODO 1: Helper method
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            isValid = int.TryParse(input, out value) &&
                      value >= min &&
                      value <= max;

            if (!isValid)
            {
                Console.WriteLine($"Please enter a number between {min} and {max}.");
            }

        } while (!isValid);

        return value;
    }
}

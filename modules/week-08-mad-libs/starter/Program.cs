/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Mikal Johnson
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

namespace MadLibs;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Mad Libs: Structure + Debugging ===");
        Console.WriteLine();

        bool playAgain;
        do
        {
            StoryTemplate template = ChooseTemplate();
            Console.WriteLine();

            string[] words = CollectWords(template);

            string story = template.GenerateStory(words);
            Console.WriteLine(story);
            Console.WriteLine();

            playAgain = ReadYesNo("Play again? (y/n): ");
            Console.WriteLine();
        }
        while (playAgain);
    }

    private static StoryTemplate ChooseTemplate()
    {
        Console.WriteLine("Choose a story template:");
        Console.WriteLine("1) Debugging at the Zoo");
        Console.WriteLine("2) The Standup Meeting");

        int choice = ReadIntInRange("Enter choice (1-2): ", 1, 2);

        if (choice == 1)
        {
            return new StoryTemplate(
                "Debugging at the Zoo",
                new string[]
                {
                    "animal",
                    "adjective",
                    "verb ending in -ing",
                    "plural noun",
                    "emotion"
                },
                "At the zoo, I saw a {0} that looked very {1}. It was {2} near the {3}, which made everyone feel {4}."
            );
        }

        return new StoryTemplate(
            "The Standup Meeting",
            new string[]
            {
                "name",
                "verb",
                "noun",
                "adjective",
                "plural noun"
            },
            "During the standup meeting, {0} said they would {1} the {2} before lunch. Everyone thought that was very {3}, especially after seeing the {4}."
        );
    }

    private static string[] CollectWords(StoryTemplate template)
    {
        Logger.Info($"Collecting {template.Prompts.Length} words for: {template.Title}");

        string[] words = new string[template.Prompts.Length];

        for (int i = 0; i < template.Prompts.Length; i++)
        {
            words[i] = ReadNonEmptyString($"Enter {template.Prompts[i]}: ");
        }

        Console.WriteLine();
        return words;
    }

    private static bool ReadYesNo(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (input.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (input.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            Logger.Warn("Please enter y or n.");
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;

            isValid = int.TryParse(input, out value) && value >= min && value <= max;

            if (!isValid)
            {
                Logger.Warn($"Please enter a number between {min} and {max}.");
            }
        }
        while (!isValid);

        return value;
    }

    private static string ReadNonEmptyString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            Logger.Warn("Input cannot be empty. Please try again.");
        }
    }
}

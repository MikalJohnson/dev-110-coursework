/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Mikal Johnson
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-based menu application that demonstrates string manipulation,
- formatted console output, loops, switch statements, and input validation.
*******************************************************************************/

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // ------------------------------------------------------------
        // TITLE BANNER
        // ------------------------------------------------------------
        // These variables store the title banner information
        // displayed at the top of the program.
        string title = "Text Menu Studio";
        string subtitle = "Strings + Console Output Patterns";

        // Creates a divider line of 48 '=' characters
        string divider = new string('=', 48);

        // Display the banner
        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper()); // Convert title to uppercase
        Console.WriteLine(subtitle);
        Console.WriteLine(divider);

        // Variable that stores the user's menu choice
        int choice = 0;

        // ------------------------------------------------------------
        // MAIN MENU LOOP
        // ------------------------------------------------------------
        // The menu repeats until the user selects option 6 (Exit)
        while (choice != 6)
        {
            // Display menu options
            Console.WriteLine("1) Greeting Card");
            Console.WriteLine("2) Name Tag Formatter");
            Console.WriteLine("3) Phrase Analyzer");
            Console.WriteLine("4) Fancy Receipt Line");
            Console.WriteLine("5) Menu Banner Builder");
            Console.WriteLine("6) Exit");

            // Read user choice using validated helper method
            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);

            // ------------------------------------------------------------
            // SWITCH STATEMENT
            // ------------------------------------------------------------
            // Executes different code depending on the menu selection
            switch (choice)
            {

                // ============================================================
                // OPTION 1: GREETING CARD
                // Demonstrates Trim, ToUpper, interpolation, and string.Format
                // ============================================================
                case 1:

                    Console.Write("Enter your name: ");
                    string rawName = Console.ReadLine() ?? "";

                    Console.Write("Enter a short message: ");
                    string message = Console.ReadLine() ?? "";

                    // Remove extra spaces from the name
                    string cleanName = rawName.Trim();

                    // Create an uppercase version of the name
                    string upperName = cleanName.ToUpper();

                    // Display a decorative greeting card box
                    Console.WriteLine(new string('*', 40));
                    Console.WriteLine("Greeting Card");

                    // Demonstrates string.Format()
                    Console.WriteLine(string.Format("Name: {0}", cleanName));

                    Console.WriteLine("Uppercase Name: " + upperName);

                    // Demonstrates string interpolation
                    Console.WriteLine($"Message: {message}");

                    Console.WriteLine(new string('*', 40));

                    break;



                // ============================================================
                // OPTION 2: NAME TAG FORMATTER
                // Demonstrates Trim, concatenation, indexing, casing
                // ============================================================
                case 2:

                    Console.Write("Enter first name: ");
                    string firstName = (Console.ReadLine() ?? "").Trim();

                    Console.Write("Enter last name: ");
                    string lastName = (Console.ReadLine() ?? "").Trim();

                    // Concatenate first and last name
                    string fullName = firstName + " " + lastName;

                    // Extract initials using string indexing
                    char firstInitial = firstName.Length > 0 ? char.ToUpper(firstName[0]) : '?';
                    char lastInitial = lastName.Length > 0 ? char.ToUpper(lastName[0]) : '?';

                    string initials = $"{firstInitial}{lastInitial}";

                    // Lowercase version of the full name
                    string lowercaseName = fullName.ToLower();

                    // Display results
                    Console.WriteLine($"[ {fullName} ]");
                    Console.WriteLine("Initials: " + initials);
                    Console.WriteLine("Lowercase: " + lowercaseName);

                    break;



                // ============================================================
                // OPTION 3: PHRASE ANALYZER
                // Demonstrates Trim, Length, Contains, Replace, Split, Join
                // ============================================================
                case 3:

                    Console.Write("Enter a phrase: ");
                    string phrase = (Console.ReadLine() ?? "").Trim();

                    // Length property counts number of characters
                    int length = phrase.Length;

                    // Convert to lowercase then check if it contains 'a'
                    bool containsA = phrase.ToLower().Contains('a');

                    // Replace spaces with dashes
                    string dashed = phrase.Replace(" ", "-");

                    // Split phrase into individual words
                    string[] words = phrase.Length > 0
                        ? phrase.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        : Array.Empty<string>();

                    // Join words into comma-separated list
                    string joinedWords = string.Join(", ", words);

                    // Display analysis results
                    Console.WriteLine("Length: " + length);
                    Console.WriteLine("Contains 'a': " + containsA);
                    Console.WriteLine("Dashed: " + dashed);
                    Console.WriteLine("Words: " + joinedWords);

                    break;



                // ============================================================
                // OPTION 4: FANCY RECEIPT LINE
                // Demonstrates numeric input, formatting, alignment, currency
                // ============================================================
                case 4:

                    Console.Write("Enter item name: ");
                    string itemName = Console.ReadLine() ?? "";

                    // Read numeric values using helper functions
                    double price = ReadDouble("Enter price: ");
                    int quantity = ReadIntInRange("Enter quantity (1-9): ", 1, 9);

                    // Calculate total price
                    double total = price * quantity;

                    Console.WriteLine();

                    // Header row with alignment formatting
                    Console.WriteLine(string.Format("{0,-20}{1,8}{2,12}", "ITEM", "QTY", "TOTAL"));

                    // Divider line
                    Console.WriteLine(new string('-', 40));

                    // Data row with currency formatting
                    Console.WriteLine(string.Format("{0,-20}{1,8}{2,12:C2}", itemName, quantity, total));

                    break;



                // ============================================================
                // OPTION 5: MENU BANNER BUILDER
                // Demonstrates centering text using PadLeft
                // ============================================================
                case 5:

                    Console.Write("Enter a title: ");
                    string bannerTitle = Console.ReadLine() ?? "";

                    Console.Write("Enter a subtitle: ");
                    string bannerSubtitle = Console.ReadLine() ?? "";

                    int width = ReadIntInRange("Enter width (30-60): ", 30, 60);

                    // Create border line based on width
                    string border = new string('=', width);

                    // Convert title to uppercase
                    string upperTitle = bannerTitle.ToUpper();

                    // Display banner
                    Console.WriteLine(border);

                    // Center text using padding formula
                    Console.WriteLine(upperTitle.PadLeft((width + upperTitle.Length) / 2));
                    Console.WriteLine(bannerSubtitle.PadLeft((width + bannerSubtitle.Length) / 2));

                    Console.WriteLine(border);

                    // Show alignment examples
                    Console.WriteLine("Centered:".PadLeft((width + "Centered:".Length) / 2));
                    Console.WriteLine("Left:".PadRight(width));
                    Console.WriteLine("Right:".PadLeft(width));

                    break;



                // ============================================================
                // OPTION 6: EXIT + STRING ANALYSIS
                // Demonstrates Equals, Substring, EndsWith, IndexOf
                // ============================================================
                case 6:

                    Console.Write("Enter a closing word: ");
                    string closingWord = Console.ReadLine() ?? "";

                    // Compare word with "goodbye" ignoring case
                    bool equalsGoodbye = closingWord.Equals("goodbye", StringComparison.OrdinalIgnoreCase);

                    // Extract first 3 characters safely
                    string firstThree = closingWord.Length >= 3
                        ? closingWord.Substring(0, 3)
                        : closingWord;

                    // Check if word ends with "!"
                    bool endsWithBang = closingWord.EndsWith("!");

                    // Find index of first space
                    int spaceIndex = closingWord.IndexOf(' ');

                    // Display analysis
                    Console.WriteLine("Equals goodbye: " + equalsGoodbye);
                    Console.WriteLine("First 3 chars: " + firstThree);
                    Console.WriteLine("Ends with !: " + endsWithBang);
                    Console.WriteLine("First space index: " + spaceIndex);

                    Console.WriteLine("Goodbye!");

                    break;
            }

            // Adds spacing between menu actions (except after Exit)
            if (choice != 6)
            {
                Console.WriteLine();
            }
        }
    }



    // ------------------------------------------------------------
    // HELPER METHOD: READINTINRANGE
    // ------------------------------------------------------------
    // Reads an integer from the user and ensures it is within
    // a specified range using input validation.
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int number;
        bool isValid;

        // do-while loop ensures the prompt runs at least once
        do
        {
            Console.Write(prompt);

            string input = Console.ReadLine() ?? "";

            // TryParse safely attempts to convert input to int
            isValid = int.TryParse(input, out number)
                      && number >= min
                      && number <= max;

        } while (!isValid);

        return number;
    }



    // ------------------------------------------------------------
    // HELPER METHOD: READDOUBLE
    // ------------------------------------------------------------
    // Reads a decimal number and validates input using TryParse
    private static double ReadDouble(string prompt)
    {
        double number;
        bool isValid;

        do
        {
            Console.Write(prompt);

            string input = Console.ReadLine() ?? "";

            // Validate numeric input
            isValid = double.TryParse(input, out number);

        } while (!isValid);

        return number;
    }
}

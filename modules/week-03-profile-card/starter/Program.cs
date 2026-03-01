namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // TODO: Collect PERSONAL INFORMATION (strings)
        // - Full name
        // - Hometown (city, state)
        // - Favorite color
        // - Dream job
        // Hint: string variableName = Console.ReadLine();
        Console.Write("Please enter your First and last name");
        string fName = Console.Readline();
        Console.Write("Please enter hometown (city, state): ");
        string hometown = Console.Readline();
        Console.Write("Enter your favorite color: ");
        string favColor = Console.Readline();
        Console.Write("Enter your dream job: ");
        string dreamJob = Console.Readline();


        // TODO: Collect ACADEMIC INFORMATION
        // - Major (string)
        // - GPA (double, 0.0-4.0)
        // - Graduation year (int)
        // - Is full-time student? (bool from yes/no)
        // Hint: double gpa = double.Parse(Console.ReadLine());
        // Hint: bool isFullTime = answer.ToLower() == "yes";
        Console.Write("");
        string major = Console.Readline();
        Console.Write("");

        Console.Write("");
        Console.Write("");

        // TODO: Collect ADDITIONAL DETAILS
        // - Age (int)
        // - Height in inches (double)
        // - Favorite number (int)

        // TODO: CALCULATE derived information
        // - Birth year = 2026 - age
        // - Years to graduation = graduationYear - 2026
        // - Height in feet and inches: feet = heightInches / 12, inches = heightInches % 12
        // - Is honor student? = gpa >= 3.5
        // - Age in months = age * 12

        // TODO: DISPLAY formatted profile card
        // Use sections with headers:
        // - PERSONAL INFORMATION
        // - ACADEMIC DETAILS
        // - CALCULATED STATISTICS
        // Use proper alignment and formatting
        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}

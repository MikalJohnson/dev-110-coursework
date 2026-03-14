namespace ProfileCard;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║         STUDENT PROFILE CARD               ║");
        Console.WriteLine("╚════════════════════════════════════════════╝\n");

        // PERSONAL INFORMATION
        Console.Write("Please enter your First and Last name: ");
        string fName = Console.ReadLine();
        Console.Write("Please enter hometown (city, state): ");
        string hometown = Console.ReadLine();
        Console.Write("Enter your favorite color: ");
        string favColor = Console.ReadLine();
        Console.Write("Enter your dream job: ");
        string dreamJob = Console.ReadLine();

        // ACADEMIC INFORMATION
        Console.Write("Enter your major: ");
        string major = Console.ReadLine();
        Console.Write("Enter your GPA (0.0 - 4.0): ");
        double gpa = double.Parse(Console.ReadLine());
        Console.Write("Enter your graduation year: ");
        int gradYear = int.Parse(Console.ReadLine());
        Console.Write("Are you a full-time student? (yes/no): ");
        string answer = Console.ReadLine();
        bool isFullTime = answer.ToLower() == "yes";

        // ADDITIONAL DETAILS
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter your height in inches: ");
        double heightInches = double.Parse(Console.ReadLine());
        Console.Write("Enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());

        // CALCULATIONS
        int birthYear = 2026 - age;
        int yearsToGrad = gradYear - 2026;
        int feet = (int)heightInches / 12;
        int inches = (int)heightInches % 12;
        bool isHonorStudent = gpa >= 3.5;
        int ageMonths = age * 12;

        // DISPLAY PROFILE CARD
        Console.WriteLine("\n════════════════ PERSONAL INFORMATION ════════════════");
        Console.WriteLine($"Name: {fName}");
        Console.WriteLine($"Hometown: {hometown}");
        Console.WriteLine($"Favorite Color: {favColor}");
        Console.WriteLine($"Dream Job: {dreamJob}");

        Console.WriteLine("\n════════════════ ACADEMIC DETAILS ════════════════════");
        Console.WriteLine($"Major: {major}");
        Console.WriteLine($"GPA: {gpa:F2}");
        Console.WriteLine($"Graduation Year: {gradYear}");
        Console.WriteLine($"Full-Time Student: {isFullTime}");

        Console.WriteLine("\n════════════════ CALCULATED STATISTICS ═══════════════");
        Console.WriteLine($"Birth Year: {birthYear}");
        Console.WriteLine($"Years Until Graduation: {yearsToGrad}");
        Console.WriteLine($"Height: {feet} ft {inches} in");
        Console.WriteLine($"Honor Student: {isHonorStudent}");
        Console.WriteLine($"Age in Months: {ageMonths}");
        Console.WriteLine($"Favorite Number: {favNumber}");

        Console.WriteLine("\n═══════════════════════════════════════════");
        Console.WriteLine("Profile complete! Good luck with your studies!");
    }
}

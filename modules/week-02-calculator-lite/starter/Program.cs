namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // Gathering user input
        Console.Write("Enter Your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");

        Console.Write("Use decimal precision? (yes/no): ");
        bool showDecimals = Console.ReadLine().ToLower() == "yes";

        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        int successfulCalculations = 0;
        string format = showDecimals ? "F2" : "F0";

        Console.WriteLine("\n--- Results ---");

        //Addition
        double sum = num1 + num2;
        Console.WriteLine($"Addition: {num1.ToString(format)} + {num2.ToString(format)} = {sum.ToString(format)}");
        // Subtraction
        double difference = num1 - num2;
        Console.WriteLine($"Subtraction: {num1.ToString(format)} - {num2.ToString(format)} = {difference.ToString(format)}");
        successfulCalculations++;
        // Multiplication
        double product = num1 * num2;
        Console.WriteLine($"Multiplication: {num1.ToString(format)} * {num2.ToString(format)} = {product.ToString(format)}");
        successfulCalculations++;

        // Division
        if (num2 != 0)
        {
            double quotient = num1 / num2;
            Console.WriteLine($"Division: {num1.ToString(format)} / {num2.ToString(format)} = {quotient.ToString(format)}");
            successfulCalculations++;
        } else
        {
            Console.WriteLine("Division: Cannot divide by zero");
        }
        // Modulus
        if (num2 != 0)
        {
            double remainder = num1 % num2;
            Console.WriteLine($"Modulus: {num1.ToString(format)} % {num2.ToString(format)} = {remainder.ToString(format)}");
            successfulCalculations++;
        } else
        {
            Console.WriteLine("Modulus: Cannot divide by zero");
        }
        // Average
        double average = (num1 + num2) / 2;
        Console.WriteLine($"Average: {average.ToString(format)}");
        successfulCalculations++;
        // Percentage Difference
        if (num1 != 0)
        {
            double percentDiff = ((num1 - num2) / num1) * 100;
            Console.WriteLine($"Percentage Difference: {percentDiff.ToString(format)}%");
            successfulCalculations++;
        }
        else
        {
            Console.WriteLine("Percentage Difference: Cannot divide by zero");
        }

        // Part 4: Final Summary
        Console.WriteLine($"\nPerformed {successfulCalculations} calculations for {name}!");
        Console.WriteLine("Thank you for using Calculator Lite!");
    }
}

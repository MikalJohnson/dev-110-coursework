# Week 2: Calculator Lite - Study Notes

**Name:**
Mikal Johnson

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer: String - Stores text, used for user's name and other inpus from the console.
Bool - Stores true or false values, used it to track decimal precision or not.
Int - stores whole numbers
double - stores numbers that includes decimals

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer:because doubles allows decimal values for a more precise value.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer:I compared user's input to the word "yes". if yes then value is set to true, otherwise its false.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: handling division by zero and making sure the program didnt crash

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer:using an if statement

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: Conditional formatting was the most confusing at first, i coded in a couple other languages.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer:"/" divides two numbers
"%"  gives the remainder

10 / 3 = 3.33
10 % 3 = 1

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer:Add the two inputs and devide by two

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: subtract the second number from the first, divide the results by the first number,
then multiply by 100 to get a percentage.

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: REads a line of text entered by the user and returns it as a string

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: Convert.ToDouble()

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: allows variables to be placed directly inside a string using $ and {}

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: F2 format numbers to two decimals, while F0 rounds to whole numbers

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: divinding by zero will cause the program to crash. checking for zeros prevents this from happening

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer:I used the boolean values to choose between f2 and f0 formatting.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. different data types
2. coverting user inputs
3. arithmetic in c#
4. how to control the programs behaviors
5. formatting to improve program outputs

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: double, it allows more accurate calculations

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: makes it easier to read

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer:positives, negatives, decimals, zero.

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: missing braces, and valuing naming issues.

## Time Spent

**Total time:** 5 hours

**Breakdown:**

-   Understanding data types: [1 hours]
-   Reading and parsing user input: [0 hours]
-   Implementing arithmetic operations: [0 hours]
-   Adding conditional formatting: [1 hours]
-   Handling division by zero: [1 hours]
-   Testing and debugging: [1 hours]
-   Writing documentation: [1 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:handing the zeros logics

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer:PLan out the program first

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer:
Its teaches me how to deal with different data types, conditionals, inputs, error handing.

# Week 6: Text Menu App - Study Notes

**Name:**
Mikal Johnson
## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: A `do-while` loop always runs at least one time before checking the condition, while a `while` loop checks the condition first before running. A `do-while` loop is best when the program needs to ask for input at least once. A `while` loop is better when something should keep repeating only as long as a condition stays true.


**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer:
I used a `do-while` loop in my helper methods for input validation, like `ReadIntInRange` and `ReadDouble`. I used it because the user has to be prompted at least once, and the loop keeps repeating until the input is valid.

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer:
I used a `while` loop for the main menu. It repeats the menu until the user chooses option 6 to exit. This made sense because the menu should keep showing until the program is supposed to end.

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer:
I did not use a `for` loop in this assignment because I did not need to count through a set number of repetitions. My program was based more on repeating until valid input was given or until the user chose to exit.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer:
I created helper methods so I would not have to repeat the same validation code in multiple places. This made the program cleaner, easier to read, and easier to update.

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer:
I used `ReadIntInRange` with a `do-while` loop. Inside the loop, I used `int.TryParse()` to make sure the input was a number, and then I checked that the number was between 1 and 6.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer:
I used `int.TryParse()` and `double.TryParse()`. These methods try to convert the user’s input into a number without crashing the program. If the conversion fails, they return `false`, and the loop asks the user again.

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer:
I used `Trim`, `ToUpper`, `ToLower`, `Replace`, `Split`, `Join`, `Contains`, `PadLeft`, `PadRight`, `Substring`, `EndsWith`, `IndexOf`, and `Equals`. I also used string concatenation, interpolation, and `string.Format()` for formatting output.

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer:
In Option 6, I used `Equals()` with `StringComparison.OrdinalIgnoreCase` to compare text without worrying about uppercase or lowercase letters. I used `Substring()` to get the first 3 characters. I used `EndsWith()` to check if the string ended with an exclamation point. I used `IndexOf()` to find the position of the first space.

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer:
String concatenation combines strings using the `+` operator. String interpolation uses `$""` and lets you insert variables directly inside the string. I used both, but interpolation feels cleaner and easier to read in most cases.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. A `do-while` loop is useful for input validation.
2. A `while` loop works well for repeating a menu.
3. `TryParse()` helps prevent crashes from bad input.
4. String methods can change and analyze text in many ways.
5. Formatting output carefully makes console programs look much better.

**Which loop felt most natural to use and why?**

Answer:
The `while` loop felt most natural because it made sense for the menu to keep repeating until the user chose to exit.

## Time Spent

**Total time:** 4 hours

**Breakdown:**

- Planning the loops: 0.5 hours
- Input validation: 1 hour
- String formatting: 1 hour
- Testing and debugging: 1 hour
- Writing documentation: 0.5 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:
The most time-consuming part was testing and debugging because the program had to match the required prompts and output formatting closely.

## Reflection

**What would you do differently next time?**

Answer:
Next time, I would test each menu option earlier as I build it instead of waiting until the end. That would help me catch formatting mistakes faster.

**How did using three different loop types improve your understanding of repetition?**

Answer:
It helped me see that different loops are useful for different situations. A `do-while` loop is good for input validation, a `while` loop is good for menu repetition, and a `for` loop is better when you know exactly how many times something should repeat.

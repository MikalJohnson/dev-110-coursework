# Week 5: Guess the Number - Study Notes

**Name:**
Mikal Johnson

## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: do-while = do it once no matter what, while = check first

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

Answer: I've used it in the helper method to key track of the program to see if it keeps going or not

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

Answer: I used the while loop while keeping track of the users guess. While loop will keep asking until the match
is equal to the random number

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

Answer: for loop is used during the game and keeping count with each iteration 

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

Answer: I created a helper method so I wouldn’t have to write the same code over 
and over for different inputs, like the max value and number of rounds. 
This keeps my code cleaner, easier to read, and easier to fix if I need to change the validation logic.

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

Answer:I used a while loop that kept asking the user for input until the number was between 10 and 100.
If the input was outside that range, it printed a message and asked again.

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

Answer:Similarly, I used a while loop to check the number of rounds. 
If the input was less than 1 or greater than 3, it repeated the prompt until the user entered a valid number.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

Answer:I used int.TryParse to check if the input could be converted to an integer.
If it couldn’t, the program told the user it was invalid and asked again, instead of crashing.

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

Answer:I used if/else statements. If the guess was less than the secret number, it said “Too low.” 
If it was higher, it said “Too high.” If it matched, it said “Correct!” and ended the round.

**How did you count the number of guesses?**
[Explain where you incremented the counter]

Answer: the for loop that counts the number of iteration using ++

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

Answer:I used the Random class and Next(min, max) method. 
This gave a random number between a minimum value (1) and the maximum value set by the user.

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

Answer:Because Random.Next(min, max)
goes up to but does not include the max value. Adding 1 ensures the max value is possible.

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

Answer:
    Max value below 10 and above 100 
    Rounds less than 1 and greater than 3
    Non-numeric input (letters, symbols)
    Correct guess on the first try
    Multiple guesses before getting it right

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

Answer:
    -Initially, the loop didn’t re-prompt for invalid numbers. I fixed this by adding int.TryParse with a loop.
    -Forgot to include max + 1 in Random.Next, which caused the max value to never be picked.
    -Counter wasn’t incrementing correctly inside the loop; I moved the increment to the right place.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1.while and do-while loops are useful for validation
2.testing different cases
3.helper methods save time
4.
5.

**Which loop felt most natural to use and why?**

Answer:The do-while loop felt most natural for input validation because 
I wanted the prompt to show at least once, even if the user immediately entered a valid number.

## Time Spent

**Total time:** [3.5 hours]

**Breakdown:**

- Planning the loops: [.5 hours]
- Input validation: [.5 hours]
- Guessing logic: [1 hours]
- Testing and debugging: [1 hours]
- Writing documentation: [.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:Building the loop

## Reflection

**What would you do differently next time?**

Answer: add more features

**How did using three different loop types improve your understanding of repetition?**

Answer:

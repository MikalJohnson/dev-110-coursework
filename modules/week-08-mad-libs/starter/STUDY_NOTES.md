# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Mikal Johnson

## Program Structure

**What helper methods did you create (and what does each one do)?**

Answer:

- `ChooseTemplate()` – Displays the two-story template options and returns the template the user selects.
- `CollectWords()` – Loops through the prompts in the selected template and collects the user’s words.
- `ReadYesNo()` – Validates yes/no input when asking the player if they want to play again.
- `ReadIntInRange()` – Ensures the user enters a valid number within a specific range.
- `ReadNonEmptyString()` – Ensures the user enters a non-empty word for each prompt.

**Why is it helpful to move code out of `Main` and into helper methods?**

Answer:

Moving code into helper methods keeps the `Main` method simple and easier to read. Each method has a specific job, which makes the program easier to understand and easier to debug. If something breaks, it’s also easier to find the problem because the logic is separated into smaller parts.

---

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**

Answer:

The `StoryTemplate` class represents a story template. It stores the title of the story, the prompts for the user to fill in, and the template text that contains placeholders. The class also contains methods that generate the final story using the words the user enters.

**How did using a template make it easier to support two different stories?**

Answer:

Using a template allowed the same code to work for multiple stories. Each template just contains different prompts and story text, but the logic for collecting words and generating the story stays the same. This makes the program easier to expand in the future.

---

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**

Answer:

I set breakpoints in the following places:

- At the start of `ChooseTemplate()` to verify the user’s selection
- Inside `CollectWords()` to watch the words array being filled
- Inside `GenerateStory()` to confirm the number of words matched the number of prompts

**What did you learn from stepping through your code line by line?**

Answer:

Stepping through the code helped me understand the order that methods run and how data moves through the program. I was able to watch variables update and verify that user input was being stored correctly.

**What bug or logic mistake did you encounter (and how did you fix it)?**

Answer:

At first, validate user input when selecting a template. This caused problems if the user entered something outside the range. I fixed it by implementing the `ReadIntInRange()` method so the program keeps asking until a valid number is entered.

---

## What I Learned

**Key takeaways from this week:**

1. Breaking programs into smaller helper methods makes code easier to read and maintain.
2. Classes can represent data and behavior together, which helps organize larger programs.
3. Using breakpoints and stepping through code makes debugging much easier.

**What part of this assignment helped you understand program structure the most?**

Answer:

Creating helper methods and separating responsibilities helped the most. Instead of writing everything in `Main`, I could organize the program into smaller pieces that each handled one job.

---

## Time Spent

**Total time:** 4 hours

**Breakdown:**

- Planning structure (methods/classes): 1 hour
- Input validation: 1 hour
- Story templates + formatting: 45 minutes
- Testing and debugging: 1 hour
- Writing documentation: 15 minutes

**Most time-consuming part:**

Answer:

Input validation took the longest because I had to make sure the program kept asking the user until they entered valid input.

---

## Reflection

**What would you improve if you had more time?**

Answer:

If I had more time, I would add more story templates and maybe improve the formatting of the output to make the stories look nicer when printed.

**How did breaking your program into smaller parts help you debug?**

Answer:

Breaking the program into smaller methods made debugging easier because I could focus on one part of the program at a time. If something was wrong with input validation or story generation, I knew exactly where to look.

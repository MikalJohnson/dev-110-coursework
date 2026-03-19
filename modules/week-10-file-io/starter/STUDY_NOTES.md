# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:** Mikal Johnson

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer:
`File.ReadAllLines` returns a string array (`string[]`). Each element of the array represents one line from the file. I used it to read the CSV file containing the habits, then looped through each line using a `foreach` loop. For each line I split the text by commas to get the habit name, status, and frequency.

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer:
It is important to skip blank lines because splitting an empty string would not produce the expected three values. If the program tried to access parts like `parts[0]`, `parts[1]`, and `parts[2]`, it could cause an index error. Skipping blank lines prevents the program from crashing.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer:
`File.WriteAllLines` writes text to a file. It takes two arguments: the file path and a string array. The path tells the program where the file should be saved, and each element of the string array becomes a line written to the file.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer:
`Select` loops through each habit and converts it into a formatted CSV string like `"Exercise,done,daily"`. `ToArray()` then converts the results into a string array. This is necessary because `File.WriteAllLines` requires a `string[]` as its input.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer:
A `FileNotFoundException` occurs when the program tries to read a file that does not exist at the given path. In this assignment it would happen if the user entered an incorrect file path when the program calls `File.ReadAllLines`.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer:
Catching `FileNotFoundException` specifically allows the program to handle the exact error we expect. Using `catch (Exception)` would catch every possible error, which could hide other bugs and make debugging harder.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. How to read files using `File.ReadAllLines` and process CSV data.
2. How to write data to files using `File.WriteAllLines`.
3. How to use LINQ methods like `Count()` and `Select()` to analyze and transform data.

**What was the trickiest part of this assignment and how did you work through it?**

Answer:
The trickiest part was loading and parsing the CSV file correctly. I had to make sure each line was split properly and that blank lines were skipped. I solved this by carefully following the instructions and testing the program step-by-step.

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 0.5 hours
- Implementing LoadHabits: 0.75 hours
- Implementing PrintHabits / PrintSummary: 0.5 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 0.75 hours
- Testing and debugging: 0.25 hours
- Writing study notes: 0.25 hours

**Most time-consuming part:**

Answer:
Implementing `LoadHabits` was the most time-consuming part because it involved reading the file, splitting the CSV data correctly, and handling errors if the file could not be found.

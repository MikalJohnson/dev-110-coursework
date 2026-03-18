# Week 7: Class Roster Builder (Arrays) - Study Notes

**Name:** Mikal Johnson

## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**

Answer:
Parallel arrays are two or more arrays that store related data using the same index positions. In this assignment, `rosterNames` stored student names and `rosterCredits` stored the number of credits for each student. If a student’s name was stored at index `0` in `rosterNames`, their credits were stored at index `0` in `rosterCredits`. This keeps the data connected even though it is stored in separate arrays.

**What is the purpose of the `count` variable?**

Answer:
The `count` variable keeps track of how many student slots in the arrays are currently being used. Since the arrays have a capacity of 3, `count` tells the program how many students have actually been added so far. Every time a new student is added, `count` increases so the next student is stored in the next available slot.

**Where did you use `count` in loops and why?**

Answer:
`count` was used in loops when printing the roster and when copying the used portion of the roster arrays. Instead of looping through the entire array length, the loop only runs from `0` to `count - 1`. This prevents the program from reading empty array slots that haven't been filled with student data yet.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**

Answer:
First, I built an array of strings that contained the formatted roster lines using the `BuildRosterLines` method. Each line included the student’s name and credits. Then I used a `foreach` loop to go through each string in that array and print it to the console. This made the printing logic clean and easy to read.

**How did you sort the roster while keeping names and credits aligned?**

Answer:
To keep the names and credits aligned, I first copied the used portion of the roster into new arrays using the `CopyUsedRoster` method. Then I used `Array.Sort()` with two arrays. When sorting by name, the names array was the primary array and the credits array moved along with it. When sorting by credits, the credits array was the primary array and the names array moved along with it. This kept each student’s name connected to their correct credit value.

## What I Learned

**Key takeaways from this week:**

1. How parallel arrays store related data using the same index.
2. How a `count` variable helps track how many elements in an array are actually used.
3. The difference between `for` loops and `foreach` loops and when each one is useful.


**Which loop felt most natural to use and why?**

Answer:
The `for` loop felt the most natural because it works well when dealing with array indexes. Since arrays rely heavily on indexes, using a `for` loop made it easier to control exactly which positions in the array were being accessed or modified.

#t Time Spent

**Total time:** ~3 hours

**Breakdown:**

- Planning the arrays/menu: 30 minutes
- Input validation: 30 minutes
- Add + print roster features: 45 minutes
- Sorting feature: 30 minutes
- Testing and debugging: 30 minutes
- Writing documentation: 15 minutes

**Most time-consuming part:**

Answer:
The most time-consuming part was implementing the sorting feature while keeping the names and credits aligned. Understanding how `Array.Sort()` works with parallel arrays took some extra time to fully understand.

## Reflection

**What would you do differently next time?**

Answer:
Next time I would plan the program structure a little more before writing the code. Thinking through the helper methods and how the arrays would interact earlier could make the implementation smoother.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer:
Using both loops helped me understand that `for` loops are better when you need to work with indexes or modify array elements, while `foreach` loops are better when you just want to read or print data. Seeing both used in the same program helped clarify when each one should be used.

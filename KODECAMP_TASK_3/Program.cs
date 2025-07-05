// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// C# Loops and Methods - Solutions Guide
// Question 1: Choosing the Right Loop (20 Points)
// A. You need to repeat a task exactly 100 times.

// Loop Type: for loop
// Reason: A for loop works best when you know exactly how many times you need to repeat something. It's designed for counting and has the counter, condition, and increment all in one line, making it clear and organized.

// B. You need to keep asking the user for a password until they enter the correct one, and they must enter it at least once.

// Loop Type: do-while loop
// Reason: Since the user must enter the password at least once, we need the loop body to execute before checking the condition. A do-while loop ensures that the code executes at least once before determining whether it should continue.

// C. You need to process items from a list, but you don't know how many items are in the list until the program runs.

// Loop Type: while loop
// Reason: A while loop works well when you don't know ahead of time how many iterations you'll need.  As long as there are things to process, it keeps going; when the condition is false, it ends.

// D. Main difference between while and do-while condition checking:

// While loop: Checks the condition BEFORE executing the loop body. If the condition is false initially, the loop body never runs.
// Do-while loop: Checks the condition AFTER executing the loop body. This guarantees the loop body runs at least once, even if the condition is false initially.



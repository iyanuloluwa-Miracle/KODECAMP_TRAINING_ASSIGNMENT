using System;

// KODECAMP_TASK_3

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


// Question 2: Introduction to Methods (20 Points)
// A. What is a "Method" (or "Function") in C# programming?

// A method is a block of code that performs a specific task. It can take inputs (called parameters) and can return a value. Methods help organize code, making it reusable and easier to read. You can think of a method as a mini-program within your program that you can call whenever you need to perform that task.



// B. DRY Principle and Methods
// The DRY principle stands for "Don't Repeat Yourself." It means you should avoid writing the same code in multiple places. Methods help follow this principle by letting you write code once and reuse it whenever needed. Instead of copying and pasting the same code, you create a method and call it from different places.



// C. PrintApplicationHeader Method and Main method implementation
partial class Program
{
    public static void Main(string[] args)
    {
        PrintApplicationHeader();
        PrintApplicationHeader();
        
        // Question 3: Countdown loop
        int counter = 5;
        
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
        
        Console.WriteLine("Loop finished!");
    }

    public static void PrintApplicationHeader()
    {
        Console.WriteLine("=== My Awesome App ===");
        Console.WriteLine("======================");
    }
}

// Question 3 Explanation:
// We start with counter = 5
// The while condition counter >= 1 means "keep going as long as counter is 1 or greater"
// Inside the loop, we print the current counter value
// Then we decrease counter by 1 using counter--
// When counter becomes 0, the condition becomes false and the loop stops




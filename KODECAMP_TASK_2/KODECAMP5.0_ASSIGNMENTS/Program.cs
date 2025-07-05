// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Task 1
Console.WriteLine("Task 1:");
string str1 = "Hello";
string str2 = "World";
object concatenedString = str1 + " " + str2;
Console.WriteLine(concatenedString);
Console.WriteLine();


// Task 2
Console.WriteLine("Task 2:");
bool is_LoggedIn = true;
bool is_Admin = false;

// 2a
bool AndConditionOperator = is_LoggedIn && is_Admin;
Console.WriteLine($"User is logged in AND admin: {AndConditionOperator}");

// 2b
bool OrConditionOperator = is_LoggedIn || is_Admin;
Console.WriteLine($"User is logged in OR admin: {OrConditionOperator}");

// 2c
bool not_Admin = !is_Admin;
Console.WriteLine($"User is NOT admin: {not_Admin}");
Console.WriteLine();



// Task 3
Console.WriteLine("Task 3:");
int number = 5;
bool is_Even = (number % 2) == 0;
Console.WriteLine($"{number} is {(is_Even ? "even" : "odd")}");


// Task 4: Time of day greeting
Console.WriteLine("Task 4:");
int hour_time = 8;
if (hour_time < 12)
{
    Console.WriteLine("Good morning!");
}
else if (hour_time < 18)
{
    Console.WriteLine("Good afternoon!");
}
else
{
    Console.WriteLine("Good evening!");
}
Console.WriteLine();


// Task 5
Console.WriteLine("Task 5:");
Console.Write("Enter your birth year: ");
int birth_Year = int.Parse(Console.ReadLine());
Console.Write("Enter the current year: ");
int current_Year = int.Parse(Console.ReadLine());
int age = current_Year - birth_Year;
Console.WriteLine($"Your approximate age is: {age}");
Console.WriteLine();



// Task 6

Console.WriteLine("Task 6:");
Console.Write("Enter your age: ");
int userAge = int.Parse(Console.ReadLine());
if (userAge >= 18)
{
    Console.WriteLine("You are eligible to vote!");
}
else
{
    Console.WriteLine("You are not yet eligible to vote.");
}
Console.WriteLine();


// Task 7
Console.WriteLine("Task 7:");
Console.Write("What is 2 + 2? ");
int answer = int.Parse(Console.ReadLine());
if (answer == 4)
{
    Console.WriteLine("Correct! Welldone Champ");
}
else
{
    Console.WriteLine("Incorrect. The answer was 4.");
}
Console.WriteLine();



// Task 8
Console.WriteLine("Task 8:");
Console.Write("Enter the first number: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
double num2 = double.Parse(Console.ReadLine());
Console.Write("Enter the operation (+, -, *, /): ");
string operation = Console.ReadLine();

switch (operation)
{
    case "+":
        Console.WriteLine($"Result: {num1 + num2}");
        break;
    case "-":
        Console.WriteLine($"Result: {num1 - num2}");
        break;
    case "*":
        Console.WriteLine($"Result: {num1 * num2}");
        break;
    case "/":
        if (num2 != 0)
        {
            Console.WriteLine($"Result: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Error: Cannot divide by zero!");
        }
        break;
    default:
        Console.WriteLine("Invalid operation entered.");
        break;
}
Console.WriteLine();


// Task 9
Console.WriteLine("Task 9:");
Console.Write("Enter your score (0-100): ");
int score = int.Parse(Console.ReadLine());

if (score < 0 || score > 100)
{
    Console.WriteLine("Invalid score entered.");
}
else if (score >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (score >= 80)
{
    Console.WriteLine("Grade: B");
}
else if (score >= 70)
{
    Console.WriteLine("Grade: C");
}
else if (score >= 60)
{
    Console.WriteLine("Grade: D");
}
else
{
    Console.WriteLine("Grade: F");
}
Console.WriteLine();

// Task 10
Console.WriteLine("Task 10:");
Console.Write("Enter first number: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
int number3 = int.Parse(Console.ReadLine());
int sum_of_numbers = number1 + number2 + number3;
Console.WriteLine($"Sum is: {sum_of_numbers}");
Console.WriteLine();

// Task 11
Console.WriteLine("Task 11:");
Console.Write("Enter company name: ");
string companyName = Console.ReadLine();
Console.Write("Enter company address: ");
string address = Console.ReadLine();
Console.Write("Enter company phone: ");
string companyPhone = Console.ReadLine();
Console.Write("Enter company fax: ");
string fax = Console.ReadLine();
Console.Write("Enter company website: ");
string website = Console.ReadLine();
Console.Write("Enter manager name: ");
string managerName = Console.ReadLine();
Console.Write("Enter manager surname: ");
string managerSurname = Console.ReadLine();
Console.Write("Enter manager phone: ");
string managerPhone = Console.ReadLine();

Console.WriteLine("\n--- Company Information ---");
Console.WriteLine($"Company: {companyName}");
Console.WriteLine($"Address: {address}");
Console.WriteLine($"Phone: {companyPhone}");
Console.WriteLine($"Fax: {fax}");
Console.WriteLine($"Website: {website}");
Console.WriteLine($"Manager: {managerName} {managerSurname}");
Console.WriteLine($"Manager Phone: {managerPhone}");
Console.WriteLine();

// Task 12
Console.WriteLine("Task 12:");
Console.Write("Enter first number: ");
int first_Number = int.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
int second_Number = int.Parse(Console.ReadLine());

if (first_Number > second_Number)
{
    Console.WriteLine($"The greater number is: {first_Number}");
}
else if (second_Number > first_Number)
{
    Console.WriteLine($"The greater number is: {second_Number}");
}
else
{
    Console.WriteLine("Both numbers are equal.");
}
Console.WriteLine();



// Task 13
Console.WriteLine("Task 13:");
int total = 0;
int count = 0;

while (count < 5)
{
    Console.Write($"Enter number {count + 1}: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int validNumber))
    {
        total += validNumber;
        count++;
    }
    else
    {
        Console.WriteLine("Invalid number. Please enter a valid integer.");
    }
}

Console.WriteLine($"Sum of the five numbers: {total}");

Console.WriteLine("\nPress any key to exit...");


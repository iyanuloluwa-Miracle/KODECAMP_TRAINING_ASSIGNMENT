using System;

class BankAccount
{
    public string AccountNumber;
    public string AccountHolder;
    public decimal Balance;


    public BankAccount(string accountNumber, string accountHolder, decimal balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0) 
        {
            Balance = Balance + amount;
            Console.WriteLine("Deposit done! New balance is: " + Balance);
        }
        else
        {
            Console.WriteLine("Please enter a positive amount!");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0) 
        {
            if (amount <= Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine("Withdrawal done! New balance is: " + Balance);
            }
            else
            {
                Console.WriteLine("Not enough money in account!");
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive amount!");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Account: " + AccountNumber + ", Holder: " + AccountHolder + ", Balance: " + Balance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount myAccount = new BankAccount("12345", "Dina Iyanuloluwa", 0);


        while (true)
        {
            Console.WriteLine("\nWelcome to Simple Bank!");
            Console.WriteLine("1. Deposit Money");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Pick a number (1-4): ");

            string choice = Console.ReadLine();

            if (choice == "4")
            {
                Console.WriteLine("Bye! Thanks for using Simple Bank!");
                break; 
            }

            if (choice == "1") 
            {
                Console.Write("How much to deposit? ");
                string amountInput = Console.ReadLine();
                decimal amount;
                if (decimal.TryParse(amountInput, out amount))
                {
                    myAccount.Deposit(amount);
                }
                else
                {
                    Console.WriteLine("That’s not a valid number!");
                }
            }
            else if (choice == "2")
            {
                Console.Write("How much to withdraw? ");
                string amountInput = Console.ReadLine();
                decimal amount;
                if (decimal.TryParse(amountInput, out amount))
                {
                    myAccount.Withdraw(amount);
                }
                else
                {
                    Console.WriteLine("That’s not a valid number!");
                }
            }
            else if (choice == "3")
            {
                myAccount.CheckBalance();
            }
            else
            {
                Console.WriteLine("Please pick a number between 1 and 4!");
            }
        }
    }
}
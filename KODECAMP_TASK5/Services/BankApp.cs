using System;
using KODECAMP_TASK5.Models;

namespace KODECAMP_TASK5.Services
{
    // Handles the user interface and menu logic for the bank app
    public class BankApp
    {
        private BankAccountService _accountService;

        public BankApp(BankAccountService accountService)
        {
            _accountService = accountService;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nWelcome to Simple Bank!");
                Console.WriteLine("1. Deposit Money");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Pick a number (1-4): ");

                string choice = Console.ReadLine() ?? "";

                if (choice == "4")
                {
                    Console.WriteLine("Bye! Thanks for using Simple Bank!");
                    break;
                }

                if (choice == "1")
                {
                    Console.Write("How much to deposit? ");
                    string amountInput = Console.ReadLine() ?? "";
                    decimal amount;
                    if (decimal.TryParse(amountInput, out amount))
                    {
                        _accountService.Deposit(amount);
                    }
                    else
                    {
                        Console.WriteLine("That’s not a valid number!");
                    }
                }
                else if (choice == "2")
                {
                    Console.Write("How much to withdraw? ");
                    string amountInput = Console.ReadLine() ?? "";
                    decimal amount;
                    if (decimal.TryParse(amountInput, out amount))
                    {
                        _accountService.Withdraw(amount);
                    }
                    else
                    {
                        Console.WriteLine("That’s not a valid number!");
                    }
                }
                else if (choice == "3")
                {
                    _accountService.CheckBalance();
                }
                else
                {
                    Console.WriteLine("Please pick a number between 1 and 4!");
                }
            }
        }
    }
}

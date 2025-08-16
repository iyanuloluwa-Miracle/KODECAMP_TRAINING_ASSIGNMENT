using System;
using KODECAMP_TASK5.Models;

namespace KODECAMP_TASK5.Services
{
    
    public class BankAccountService
    {
        private BankAccount _account;

        public BankAccountService(BankAccount account)
        {
            _account = account;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _account.Balance += amount;
                Console.WriteLine($"Deposit done! New balance is: {_account.Balance}");
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
                if (amount <= _account.Balance)
                {
                    _account.Balance -= amount;
                    Console.WriteLine($"Withdrawal done! New balance is: {_account.Balance}");
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
            Console.WriteLine($"Account: {_account.AccountNumber}, Holder: {_account.AccountHolder}, Balance: {_account.Balance}");
        }
    }
}

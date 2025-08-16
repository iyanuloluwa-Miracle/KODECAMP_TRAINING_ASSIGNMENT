using System;

namespace KODECAMP_TASK5.Models
{
    
    public class BankAccount
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
    }
}

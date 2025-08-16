using System;

namespace KODECAMP_TASK5.Models
{
    // Represents a transaction (deposit/withdrawal)
    public class Transaction
    {
        public int Id { get; set; }
        public int BankAccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; } // "Deposit" or "Withdrawal"
    }
}

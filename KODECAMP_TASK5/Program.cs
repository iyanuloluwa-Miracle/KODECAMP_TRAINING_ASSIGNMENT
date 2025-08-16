using System;
using KODECAMP_TASK5.Models;
using KODECAMP_TASK5.Services;

// Entry point for the Simple Bank application
class Program
{
    static void Main(string[] args)
    {
    BankAccount myAccount = new BankAccount("12345", "Dina Iyanuloluwa", 0);
    BankAccountService accountService = new BankAccountService(myAccount);
    BankApp app = new BankApp(accountService);
    app.Run();
    }
}
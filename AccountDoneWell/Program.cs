using System;

namespace AccountDoneWell
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount bensSavingsAccount = new SavingsAccount("Ben Saving", 13.5m);
            bensSavingsAccount.Deposit(100);
            bensSavingsAccount.CalculateInterest();

            CurrentAccount bensCurrentAccount = new CurrentAccount("Current Ben", 500);
            bensCurrentAccount.Deposit(40);
            bensCurrentAccount.ChangeOverdraftLimit(700);
        }
    }
}

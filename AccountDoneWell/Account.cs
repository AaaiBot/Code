namespace AccountDoneWell
{
    public class Account
    {
        public static int NextAccountNumber = 10000000; // shared between all instances
        public string AccountName; // unique per instance
        public int AccountNumber; // unique per instance
        public decimal Balance; // unique per instance

        public Account(string name)
        {
            AccountName = name;
            Balance = 0;
            AccountNumber = NextAccountNumber++;
            System.Console.WriteLine($"{AccountName} has been allocated account number {AccountNumber}");
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            System.Console.WriteLine($"{amount:C} has been deposited into acccount number {AccountNumber}");
        }
    }
}
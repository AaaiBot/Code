namespace AccountDoneWell
{
    public class CurrentAccount : Account
    {
        private readonly decimal _overdraftLimit;
        public CurrentAccount(string name, decimal overdraftLimit) : base(name)
        {
            _overdraftLimit = overdraftLimit;
        }

        public void ChangeOverdraftLimit(decimal overdraftLimit)
        {
            string message =
                $"The overdraft limit for {AccountName}s account ({AccountNumber}) is now {overdraftLimit:C}";
            System.Console.WriteLine(message);
        }
    }
}
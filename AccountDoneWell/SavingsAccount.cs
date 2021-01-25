namespace AccountDoneWell
{
    public class SavingsAccount : Account
    {
        private readonly decimal _interestRate;
        public SavingsAccount(string name, decimal interestRate) : base(name)
        {
            _interestRate = interestRate;
        }

        public void CalculateInterest()
        {
            decimal interest = _interestRate / 100 * Balance; 
            string message = 
                $"The annual interest for {AccountName}s account ({AccountNumber}) is {interest:C}";
            System.Console.WriteLine(message);
        }
    }
}
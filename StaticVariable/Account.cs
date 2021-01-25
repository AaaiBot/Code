namespace StaticVariable
{
    public class Account
    {
        static int StaticAccountNumber = 10000000; // shared between all instances
        string _name; // unique per instance
        int _number; // unique per instance

        public Account(string name)
        {
            _name = name;
            _number = StaticAccountNumber++;
            System.Console.WriteLine($"{_name} has been allocated account number {_number}");
        }
    }
}
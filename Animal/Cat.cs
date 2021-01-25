namespace Animal
{
    public class Cat : Pet
    {
        public Cat(string name) : base(name)
        {
        }

        public void Meow()
        {
            System.Console.WriteLine($"{Name} says Meow, meow.");
        }
    }
}
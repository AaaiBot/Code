namespace Animal
{
    public class Dog : Pet
    {
        public Dog(string name) : base(name)
        {
        }

        public void Bark()
        {
            System.Console.WriteLine($"{Name} says Woof, woof.");
        }
    }
}
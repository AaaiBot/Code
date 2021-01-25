namespace Animal
{
    public class Pet
    {
        public string Name;

        public Pet(string name)
        {
            Name = name;
        }

        public void Move(string location)
        {
            System.Console.WriteLine($"{Name} has moved to {location}");
        }
    }
}
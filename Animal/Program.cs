using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var tipsy = new Cat("Tipsy");
            var tiggy = new Cat("Tiggy");
            var rover = new Dog("Rover");

            tipsy.Meow();
            tiggy.Meow();
            tipsy.Move("the garden");
            rover.Bark();
            rover.Move("the kitchen");
        }
    }
}

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!" + Math.PI);
        }
    }

    public static class Math
    {
        //
        // Summary:
        //     Represents the ratio of the circumference of a circle to its 
        //     diameter, specified by the constant, π.
        public const double PI = 3.1415926535897931;
    }
}

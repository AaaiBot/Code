using System;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"100° Celcius is {TemperatureConverter.CelsiusToFahrenheit(100)}° F");
            Console.WriteLine($"98.6° Fahrenheit is {TemperatureConverter.FahrenheitToCelsius(98.6)}° C");
        }
    }
}

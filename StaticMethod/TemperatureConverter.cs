namespace StaticMethod
{
    public static class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            // Convert Celsius to Fahrenheit.
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            // Convert Fahrenheit to Celsius.
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }

    }
}
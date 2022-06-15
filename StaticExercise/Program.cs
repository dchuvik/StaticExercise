using System;

namespace StaticExercise
{
    //Create a new console app called StaticExercise.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please input degree's in Celsius to Convert to Fahrenheit: ");
            Console.WriteLine($"{TempConverter.CelsiusToFahrenheit(Convert.ToDouble(Console.ReadLine()))} degrees Fahrenheit");
            Console.WriteLine();

            Console.WriteLine($"Please input degree's in Fahrenheit to Convert to Celsius: ");
            Console.WriteLine($"{TempConverter.FahrenheitToCelsius(Convert.ToDouble(Console.ReadLine()))} degrees Celsius");
        }
    }
}

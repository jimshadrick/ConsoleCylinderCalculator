using System;

namespace ConsoleCylinderCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print a greeting message.
            Console.WriteLine("Welcome to the Cyclinger Calculator 1.0");

            // Read in the cylinder's radius from the user.
            Console.WriteLine("Enter the cylinder's radius: ");
            string radiusAsString = Console.ReadLine();
            double radius = Convert.ToDouble(radiusAsString);

            // Read in the cylinder's height from the user.
            Console.WriteLine("Enter the cylinder's height: ");
            string heightAsString = Console.ReadLine();
            double height = Convert.ToDouble(heightAsString);

            //double pi = 3.141592654;    //TODO: Handle this a better way in the future
            double pi = Math.PI; 

            // Calculate the volume and surface area.
            double volume = pi * radius * radius * height;
            double surfaceArea = 2 * pi * radius * (radius + height);

            // Output results.
            Console.WriteLine($"The cylinder's volume is: {volume} cubic units.");
            Console.WriteLine($"The cylinder's surface area is: {surfaceArea} square units.");

            
        }
    }
}

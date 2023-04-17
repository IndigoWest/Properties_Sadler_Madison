// System namespace needed to use Console class.
using System;

// My collection of classes for this project.
namespace Properties_Sadler_Madison
{
    // Main class for the program
    class Program
    {
        // The Main method is executed when the application starts
        static void Main(string[] args)
        {
            // Initializes new Car() under Car car
            Car car = new Car();
            // Assigns car.Make to Chevy
            car.Make = "Chevy";
            // Assigns car.Model to Trax
            car.Model = "Trax";

            // Prints to the console the make and model of car
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            // Initializes new Car() under Car car2
            Car car2 = new Car();
            // Assigns car2.Make to Ford
            car2.Make = "Ford";
            // Assigns car2.Model to Fusion
            car2.Model = "Fusion";

            // Prints to the console the make and model of car2
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");
        }
    }
}

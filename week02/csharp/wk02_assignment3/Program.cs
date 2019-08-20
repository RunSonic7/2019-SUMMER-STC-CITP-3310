/*
Week 2 - Assignment 3 - Circle Calculations
Name: Juan Mireles II
Course: CITP 3310.V20 - Survey of Programming Languages
Semester: Summer III 2019
Due Date: Sunday, June 16, 2019 at 11:59PM CDT
*/

using System;

namespace wk02_assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            String userInput;
            int radius;
            double diameter;
            double circumference;
            double area;
            bool validEntry = false;

            // Title
            Console.WriteLine("=== CIRCLE CALCULATIONS ===");

            // Continue loop until entry is valid (true).
            do
            {
                // As user for input
                Console.Write("Please enter the radius of the circle:   ");
                userInput = Console.ReadLine();

                // Validate if the input is a valid entry.
                if (int.TryParse(userInput, out radius) == true)
                {
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid entry.\n");
                }
            } while (validEntry == false);

            // Calculate Diameter
            diameter = 2 * radius;
            // Calculate Circumference
            circumference = Math.PI * diameter; // 2 * Math.Pi * radius also works
            // Calculate Area
            area = Math.PI * Math.Pow(radius, 2.0);

            // Output Calculations to User
            Console.Write("\n---- Calculations ----" +
                $"\nRadius:\t\t{radius}" +
                $"\nDiameter:\t{diameter}" +
                $"\nCircumference:\t{circumference}" +
                $"\nArea:\t\t{area}\n");
        }
    }
}

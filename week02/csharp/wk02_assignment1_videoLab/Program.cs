/*
Week 2 - Assignment 1 - Video Lab
Name: Juan Mireles II
Course: CITP 3310.V20 - Survey of Programming Languages
Semester: Summer III 2019
Due Date: Sunday, June 16, 2019 at 11:59PM CDT
 */

using System;

namespace assignment1_videoLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string name;
            String inputAge;
            int age;
            int daysLived;
            int approxLeapYearDays;

            // Welcome
            Console.WriteLine("\n=== HOW LONG HAVE YOU LIVED FOR? ===");

            // Ask User for their name
            Console.Write("Hello! What is your first name?  ");
            name = Console.ReadLine();

            // Ask user for their age
            Console.Write($"\nHi {name}! What is your age in years? (round " +
            "to nearest year, please):  ");
            inputAge = Console.ReadLine();


            if (int.TryParse(inputAge, out age) == true) {

                // Calculate Leap Year Days & Days Lived
                approxLeapYearDays = age / 4;
                daysLived = (age * 365) + approxLeapYearDays;
                Console.WriteLine($"\nYou have lived for over {daysLived} days.");

                // Check if user is an adult or not.
                if (age >= 18)
                {
                    Console.WriteLine("Based on your age, you are considered a " +
                    "legal adult.");
                }
                else
                {
                    Console.WriteLine("Based on your age, you are not legally " + 
                    "considered an adult.");
                }
            } else {
                // User entered an invalid age.
                Console.WriteLine("I am sorry but that is not a valid age." +
                "\nPlease re-run the program and try again.");
            }
        }
    }
}

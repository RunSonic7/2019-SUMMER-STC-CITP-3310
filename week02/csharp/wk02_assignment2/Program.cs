/*
Week 2 - Assignment 2 - Odd or Even
Name: Juan Mireles II
Course: CITP 3310.V20 - Survey of Programming Languages
Semester: Summer III 2019
Due Date: Sunday, June 16, 2019 at 11:59PM CDT
*/

/*
 Sources:
 Try Parse
 https://docs.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=netframework-4.8
 do while loop
 https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/do
*/

using System;

namespace wk02_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            String userInput;
            int userInputInt;
            int remainder;
            bool validEntry = false;

            // Welcome Title
            Console.WriteLine("=== Welcome to ODD or EVEN ===");

            do
            {
                // As user for input
                Console.Write("Please enter a number.   ");
                userInput = Console.ReadLine();

                // Validate if the input is a valid entry.
                if (int.TryParse(userInput, out userInputInt) == true)
                {
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine("Sorry, that is not a valid entry.\n");
                }
            } while (validEntry == false);

            // Perform check if number is odd or even.
            remainder = userInputInt % 2;

            if (remainder == 0)
            {
                Console.WriteLine($"\nThe number {userInputInt} is even.");
            }
            else
            {
                Console.WriteLine($"\nThe number {userInputInt} is odd.");
            }
        }
    }
}

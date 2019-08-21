/*
    Week 7 - Assignment 3 - Calculating Distance (Methods)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 21, 2019 at 11:59PM CDT
    Makeup work for illness
*/

using System;

namespace wk7assignment3Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double x1;
            double y1;
            double x2;
            double y2;
            bool validator;

            Console.WriteLine("=======================================================");
            Console.WriteLine("======== CALCULATE DISTANCE BETWEEN TWO POINTS ========");
            Console.WriteLine("=======================================================\n");

            // Validate Inputs
            do
            {
                Console.Write("Enter the value of X1:   ");
                Tuple<double, bool> dataInputReturn = validateUserInput(Console.ReadLine());
                x1 = dataInputReturn.Item1;
                validator = dataInputReturn.Item2;
            } while (validator == false);

            do
            {
                Console.Write("Enter the value of Y1:   ");
                Tuple<double, bool> dataInputReturn = validateUserInput(Console.ReadLine());
                y1 = dataInputReturn.Item1;
                validator = dataInputReturn.Item2;
            } while (validator == false);

            do
            {
                Console.Write("Enter the value of X2:   ");
                Tuple<double, bool> dataInputReturn = validateUserInput(Console.ReadLine());
                x2 = dataInputReturn.Item1;
                validator = dataInputReturn.Item2;
            } while (validator == false);

            do
            {
                Console.Write("Enter the value of Y2:   ");
                Tuple<double, bool> dataInputReturn = validateUserInput(Console.ReadLine());
                y2 = dataInputReturn.Item1;
                validator = dataInputReturn.Item2;
            } while (validator == false);

            // Present distance to user
            Console.WriteLine($"\nThe distance is {calculateDistance(x1, y1, x2, y2)}");
        }

        static Tuple<double, bool> validateUserInput(string userInput)
        {
            double validUserInput = 0;
            bool validator = false;

            if (double.TryParse(userInput, out double parsedUserInput))
            {
                validUserInput = parsedUserInput;
                validator = true;
            }
            else
            {
                validUserInput = 0;
                validator = false;
                Console.WriteLine("Invalid Input. Please Try Again\n");
            }
            return Tuple.Create(validUserInput, validator);
        }
        static double calculateDistance(double X1, double Y1, double X2, double Y2)
        {
            return Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        }
    }
}

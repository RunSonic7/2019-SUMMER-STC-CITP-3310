/*
    Week 6 - Assignment 2 - Video Lab - Control Statements (Part 2 or Part 2) - Switch
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 14, 2019 at 11:59PM CDT
    Makeup Work due to illness
*/

using System;

namespace wk6videoLabProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("This is a greade Letter Converter");
            Console.WriteLine("Put a number between 0 to 100 and it will be converted to a letter grade.");
            Console.WriteLine("Type \"x\" to exit.");

            do
            {
                Console.Write("Number Grade: ");
                input = Console.ReadLine();

                if (input != "x" && (int.Parse(input) >= 0 && int.Parse(input) <= 100))
                {

                    int grade = int.Parse(input);

                    switch (grade / 10)
                    {
                        case 10:
                        case 9:
                            Console.WriteLine("A");
                            break;
                        case 8:
                            Console.WriteLine("B");
                            break;
                        case 7:
                            Console.WriteLine("C");
                            break;
                        case 6:
                            Console.WriteLine("D");
                            break;
                        default:
                            Console.WriteLine("F");
                            break;
                    }
                }
            } while (input != "x");
        }
    }
}

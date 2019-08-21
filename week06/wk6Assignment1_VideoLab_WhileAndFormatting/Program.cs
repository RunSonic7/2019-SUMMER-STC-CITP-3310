/*
    Week 6 - Assignment 1 - Video Lab - Control Statements (Part 2 or Part 2) - Formatting
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 14, 2019 at 11:59PM CDT
    Makeup Work due to illness
*/

using System;

namespace wk6videoLabProgram1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            while (counter < 11)
            {
                Console.Write("*");
                Console.Write($"{counter++,10:C}");
                Console.Write("*\n");
            }

            string myName = "Juan Mireles II";
            string textWithTime = String.Format("Today is {0:d}, and the time is {0:t}, and my name is {1}", DateTime.Now, myName);
            Console.WriteLine(textWithTime);
        }
    }
}

/*
    Week 5 - Assignment 1 - Video Lab - Control Statements (Part 2)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 7, 2019 at 11:59PM CDT
    Makeup Work due to illness
*/

using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                for (int j = i; j <= 10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

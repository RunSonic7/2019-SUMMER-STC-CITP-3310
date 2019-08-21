/*
    Week 8 - Assignment 1 - Video Lab - Grade Calculator (Arrays)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 14, 2019 at 11:59PM CDT
    Makeup work for illness
*/

using System;

namespace wk8videoLab
{
    class Program
    {
        private enum letterGrade
        {
            A = 90,
            B = 80,
            C = 70,
            D = 60,
            F = 50
        }
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Please Provide all arguements, should be 2 interger values");
            }
            else
            {
                //Console.WriteLine("How many students do you want to grade?");
                int students = int.Parse(args[0]);

                //Console.WriteLine("How many grades per student do you want to grade?");
                int grades = int.Parse(args[1]);

                int[,] studentGrades = new int[students, grades];
                double[] finalGrades = new double[students];

                Random r = new Random();

                for (int student = 0; student < students; student++)
                {
                    double total = 0;
                    for (int grade = 0; grade < grades; grade++)
                    {
                        studentGrades[student, grade] = r.Next(50, 101);
                        Console.WriteLine($"Student {student + 1}, Grade {grade + 1}: {studentGrades[student, grade]}");
                        total += studentGrades[student, grade];
                    }
                    finalGrades[student] = total / grades;
                }
                Console.WriteLine("\nFinal Grades are: ");

                for (int i = 0; i < finalGrades.Length; i++)
                {
                    double grade = (Math.Floor(finalGrades[i] / 10) * 10);
                    Console.WriteLine($"Student {i + 1}: {finalGrades[i]:0.00} - {(letterGrade)grade}");
                }
            }
        }
    }
}

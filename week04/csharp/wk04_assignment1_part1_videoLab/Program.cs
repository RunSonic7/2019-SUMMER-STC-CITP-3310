/*
    Week 4 - Assignment 1 - Video Lab - Control Statements (Part 1)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, June 30, 2019 at 11:59PM CDT
*/

using System;

namespace wk04_assignment1_part1_videoLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Grade alex = new Grade(96);
            Console.WriteLine(alex.GradeNumber);
            Console.WriteLine(alex.GradeLetter());
            alex.GradeStatus();
            alex.SillyValidation();
        }

    }
    class Grade
    {

        public int GradeNumber { get; set; }

        public Grade(int number)
        {
            if (number >= 0)
            {
                if (number <= 100)
                {
                    GradeNumber = number;
                }
            }
        }

        public string GradeLetter()
        {
            string gradeLetter;
            if (GradeNumber >= 90)
            {
                gradeLetter = "A";
            }
            else if (GradeNumber >= 80)
            {
                gradeLetter = "B";
            }
            else if (GradeNumber >= 70)
            {
                gradeLetter = "C";
            }
            else if (GradeNumber >= 60)
            {
                gradeLetter = "D";
            }
            else
            {
                gradeLetter = "F";
            }

            return gradeLetter;
        }

        public void GradeStatus()
        {
            Console.WriteLine(GradeNumber > 59 ? "Passed!" : "Failed");
        }

        public void SillyValidation()
        {
            int control = GradeNumber;
            int counter = 0;

            while (control > 0)
            {
                Console.Write($"{++counter}.-");
                GradeStatus();
                control -= 10;
                // DRY - Don't Repeat Yourself!
            }
        }
    }
}

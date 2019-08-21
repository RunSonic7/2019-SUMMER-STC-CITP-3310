/*
    Week 5 - Assignment 2 - Control Statements (Bar Charts)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 7, 2019 at 11:59PM CDT
    Makeup Work due to illness
*/

using System;
using System.Collections.Generic;

namespace barChart
{
    class BarChartDisplay
    {
        static void Main(string[] args)
        {
            List<BarChart> listOfBarData = new List<BarChart>();



            String userInputValue;
            bool validator = false;
            String[] nth = { "first", "second", "third" };

            Console.WriteLine("=======================================================");
            Console.WriteLine("====================== BAR CHART ======================");
            Console.WriteLine("=======================================================\n");

            Console.WriteLine("Please enter 3 values between 1 and 30 inclusive.");

            for (int i = 0; i < 3; i++)
            {
                validator = false;
                do
                {
                    Console.Write($"\nPlease enter the {nth[i]} value:\t");
                    userInputValue = Console.ReadLine();

                    // Error Handling
                    if (int.TryParse(userInputValue, out int userInputValueInt))
                    {
                        if ((userInputValueInt >= 1) && (userInputValueInt <= 30))
                        {
                            listOfBarData.Add(new BarChart(userInputValueInt));
                            validator = true;
                        }
                        else
                        {
                            Console.WriteLine("*** Input not valid. ***");
                        }
                    }
                    else
                    {
                        Console.WriteLine("*** Input not valid. ***");
                    }
                } while (validator == false);
            }

            Console.WriteLine("\n=======================================================");
            Console.WriteLine("====================== BAR CHART ======================");
            Console.WriteLine("=======================================================\n");

            // Display Data as Bar Chart
            Console.WriteLine("Value\tBar");
            foreach (BarChart item in listOfBarData)
            {
                Console.Write($"{item.BarValue}\t");
                for (int i = 1; i <= item.BarValue; i++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }
        }
    }


}

/*
    Week 5 - Assignment 2 - Control Statements (Bar Charts)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 7, 2019 at 11:59PM CDT
    Makeup Work due to illness
*/

using System;

class BarChart
{
    private int barValue;

    public int BarValue
    {
        get
        {
            return barValue;
        }
        set
        {
            if ((value >= 1) && (value <= 30) && ((value % 2 == 0) || (value % 2 == 1)))
            {
                barValue = value;
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }
    }

    public BarChart(int theBarValue)
    {
        BarValue = theBarValue;
    }

}
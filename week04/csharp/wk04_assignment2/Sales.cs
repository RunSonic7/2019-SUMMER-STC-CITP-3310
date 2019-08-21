/*
    Week 4 - Assignment 2 - Sales/Commission Calculator (Control Statements Part 1)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, June 30, 2019 at 11:59PM CDT
*/

using System;

class Sales
{
    private int quantity;
    private decimal pricePerUnit;

    public int Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
            if (value > 0)
            {
                quantity = value;
            }
            else
            {
                Console.Write("\nThe quantity entered is invalid.");
            }
        }
    }

    public decimal PricePerUnit
    {
        get { return pricePerUnit; }
        set
        {
            if (value > 0)
            {
                pricePerUnit = value;
            }
            else
            {
                Console.Write("\nThe price per unit entered is invalid.\n");
            }
        }
    }

    public Sales(int theQuanity, decimal thePricePerUnit)
    {
        Quantity = theQuanity;
        PricePerUnit = thePricePerUnit;
    }
}
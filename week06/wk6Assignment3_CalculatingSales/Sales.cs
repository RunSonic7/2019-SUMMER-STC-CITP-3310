/*
    Week 6 - Assignment 2 - Sales Calculator (Control Statements Part 2 of 2)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 14, 2019 at 11:59PM CDT
    Makeup work for illness
*/

using System;

class Sales
{
    public int ProductNumber { get; set; }
    public decimal ProductValue { get; set; }
    public decimal QuantitySold { get; set; }

    public Sales(int theProductNo, decimal theProductValue, decimal theQuantitySold)
    {
        ProductNumber = theProductNo;
        ProductValue = theProductValue;
        QuantitySold = theQuantitySold;
    }
}
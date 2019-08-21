/*
    Week 3 - Assignment 2 - Invoice (Classes)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, June 23, 2019 at 11:59PM CDT
*/

using System;

class Invoice
{
    // 4 properties of an instance of Invoice
    public string PartNumber { set; get; }
    public string PartDescription { set; get; }
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

    // Constructor
    public Invoice(string partNumber, string partDescription, int theQuantity, decimal thePricePerUnit)
    {
        PartNumber = partNumber;
        PartDescription = partDescription;
        Quantity = theQuantity;
        PricePerUnit = thePricePerUnit;
    }
}
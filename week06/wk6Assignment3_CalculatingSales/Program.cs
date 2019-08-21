/*
    Week 6 - Assignment 2 - Sales Calculator (Control Statements Part 2 of 2)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 14, 2019 at 11:59PM CDT
    Makeup work for illness
*/

using System;
using System.Collections.Generic;

namespace calculatingSales
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sales> listOfSales = new List<Sales>();
            String userInputProductNumber;
            String userInputQuantitySold;
            decimal productValue = 0.0m;
            decimal invoiceTotal = 0.0m;
            int parsedUserInputProductNumber;
            int parsedUserInputQuantitySold;

            Console.WriteLine("=======================================================");
            Console.WriteLine("======================= INVOICE =======================");
            Console.WriteLine("=======================================================");
            Console.WriteLine("\nProduct 1: $2.98    Product 2: $4.50    Product 3: $9.98\n");
            Console.WriteLine("Enter \"x\" on either entry to end input.\n");

            do
            {
                // Ask for user input
                Console.Write("Input Product Number:   ");
                userInputProductNumber = Console.ReadLine();
                Console.Write("Input Quantity:   ");
                userInputQuantitySold = Console.ReadLine();

                // If x is any of the entries, break loop and display
                if (userInputProductNumber == "x" || userInputQuantitySold == "x")
                {
                    break;
                }
                // If user inputs any other character or punctuation, handle as invalid input
                else if (int.TryParse(userInputProductNumber, out parsedUserInputProductNumber) == false ||
                int.TryParse(userInputQuantitySold, out parsedUserInputQuantitySold) == false)
                {
                    Console.WriteLine("***** Input not valid, please try again. *****\n");
                }
                // Process valid inputs
                else if (userInputProductNumber != "x" &&
                userInputQuantitySold != "x" &&
                (int.Parse(userInputProductNumber) >= 1 &&
                int.Parse(userInputProductNumber) <= 3) &&
                int.Parse(userInputQuantitySold) > 0)
                {

                    int productNumber = int.Parse(userInputProductNumber);
                    int quantitySold = int.Parse(userInputQuantitySold);

                    switch (productNumber)
                    {
                        case 1:
                            productValue = 2.98m;
                            break;
                        case 2:
                            productValue = 4.50m;
                            break;
                        case 3:
                            productValue = 9.98m;
                            break;

                    }
                    listOfSales.Add(new Sales(productNumber, productValue, quantitySold));
                }
                else
                {
                    Console.WriteLine("***** Your entry was invalid. *****\n");
                }
            } while (userInputProductNumber != "x" && userInputQuantitySold != "x");

            // Display Invoice
            string[] headers = { "ProductNo", "QuantitySold", "Line Total", "Invoice Total:" };

            Console.WriteLine("\n=======================================================");
            Console.WriteLine("======================= INVOICE =======================");
            Console.WriteLine("=======================================================\n");

            // Display Headers
            Console.WriteLine($"{headers[0],-12}{headers[1],-15}{headers[2],-12} ");

            // Display Line Items
            foreach (Sales item in listOfSales)
            {
                Console.Write($"{item.ProductNumber,-12}");
                Console.Write($"{item.QuantitySold,-15}");
                Console.Write($"{item.ProductValue,-12:C}\n");

                invoiceTotal += item.QuantitySold * item.ProductValue;
            }

            // Display Grand Total
            Console.WriteLine($"\n{headers[3],26} {invoiceTotal,6:C}");
        }
    }
}

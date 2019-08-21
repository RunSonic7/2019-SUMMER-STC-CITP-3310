/*
    Week 4 - Assignment 2 - Sales/Commission Calculator (Control Statements Part 1)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, June 30, 2019 at 11:59PM CDT
*/

using System;
using System.Collections.Generic;

namespace wk04_assignment2
{
    class SalesCommissionApp
    {
        const decimal COMMISSION_PERCENTAGE = 0.09m;
        static void Main(string[] args)
        {
            // List to hold record of sales
            List<Sales> listOfSales = new List<Sales>();

            String userEnterItemResponse;
            String userInputQuanity;
            String userInputPricePerUnit;

            decimal baseSalary = 200.00m;
            int itemNumber = 1;
            decimal salesTotal = 0.00m;

            Console.WriteLine("=======================================================");
            Console.WriteLine("================ COMMISSION CALCULATOR ================");
            Console.WriteLine("=======================================================");

            do
            {
                Console.Write("\nPlease enter the quantity of item type sold:\t");
                userInputQuanity = Console.ReadLine();

                Console.Write("Please Enter the item cost (Format X.XX):\t");
                userInputPricePerUnit = Console.ReadLine();

                // Error Handling
                if (int.TryParse(userInputQuanity, out int userInputQuanityInt))
                {
                    if (decimal.TryParse(userInputPricePerUnit, out decimal userInputPricePerUnitDec))
                    {
                        // Add data to list
                        listOfSales.Add(new Sales(userInputQuanityInt, userInputPricePerUnitDec));

                        Console.WriteLine("\n+++++ Added Successfully. +++++");
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

                Console.Write("Would you like to add another item?\n(Type Y for Yes, N or any other key for No):\t");

                userEnterItemResponse = Console.ReadLine();

            } while ((userEnterItemResponse == "Y") || (userEnterItemResponse == "y"));

            Console.WriteLine("\n=======================================================");
            Console.WriteLine("==================== PAYOUT REPORT ====================");
            Console.WriteLine("=======================================================\n");

            // Process Data
            Console.WriteLine($"No.\tQuantity\tPrice Per Unit");
            foreach (Sales item in listOfSales)
            {
                Console.WriteLine($"{itemNumber}\t{item.Quantity}\t\t$ {item.PricePerUnit}");
                salesTotal += item.Quantity * item.PricePerUnit;
                itemNumber++;
            }

            Console.WriteLine($"\nTotal Amount of Sales:\t$ {salesTotal}");
            Console.WriteLine($"\nBase Salary:\t\t$ {baseSalary}");
            Console.WriteLine($"Commission From Sales\t$ {CalculateCommissionAmount(salesTotal)}");
            Console.WriteLine($"Total Payout:\t\t$ {CalculateTotalPayout(baseSalary, CalculateCommissionAmount(salesTotal))}");
        }

        //Calculate Comission Amounts
        static decimal CalculateCommissionAmount(decimal totalSalesAmount)
        {
            return Math.Round(totalSalesAmount * COMMISSION_PERCENTAGE, 2);
        }

        static decimal CalculateTotalPayout(decimal baseAmount, decimal commission)
        {
            return baseAmount + commission;
        }
    }
}

/*
    Week 3 - Assignment 2 - Invoice (Classes)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, June 23, 2019 at 11:59PM CDT
*/

/*  Sources
    Lists
    https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.8
    foreach in 
    https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/foreach-in
*/

using System;
using System.Collections.Generic;

namespace InvoiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // List to hold items
            List<Invoice> invoiceItemsDetails = new List<Invoice>();

            // Program variables
            String userInputPartNumber;
            String userInputPartDescription;
            int userInputQuantity;
            decimal userInputPricePerUnit;
            decimal invoiceTotal = 0.00m;
            String userEnterItemResponse = " ";

            // Welcome Title
            Console.WriteLine("=========== INVOICE BUILDER ===========");

            // Ask User to input the item information
            // Ask User to confirm if more items needed or not.
            do
            {
                Console.WriteLine("\nPlease Enter the following information:\n");

                Console.Write("Part Number: \t\t");
                userInputPartNumber = Console.ReadLine();

                Console.Write("Part Description: \t");
                userInputPartDescription = Console.ReadLine();

                // Need to validate
                Console.Write("Quantity: \t\t");
                userInputQuantity = int.Parse(Console.ReadLine());

                // Need to validate
                Console.Write("Price Per Unit \t\t$ ");
                userInputPricePerUnit = decimal.Parse(Console.ReadLine());

                // Add item to List of Invoice objects
                invoiceItemsDetails.Add(new Invoice(
                    userInputPartNumber,
                    userInputPartDescription,
                    userInputQuantity,
                    userInputPricePerUnit)
                    );

                // Remove item if invalid entry
                // if (invoiceItemsDetails[invoiceItemsDetails.Count - 1].Quantity < 0) {
                //     invoiceItemsDetails.Remove();

                // }

                Console.Write("\nWould you like to add another item?\n(Type Y for Yes, N or any other key for No and Enter):  ");

                userEnterItemResponse = Console.ReadLine();



            } while ((userEnterItemResponse == "Y") || (userEnterItemResponse == "y"));

            // Display Invoice to User
            Console.WriteLine("\n========================== INVOICE ===========================");
            Console.WriteLine("Part Number\tPart Desc.\tQuantity\tPrice Per Unit");
            foreach (Invoice item in invoiceItemsDetails)
            {
                Console.WriteLine($"{item.PartNumber}\t\t{item.PartDescription}\t\t{item.Quantity}\t\t$ {item.PricePerUnit}");
                invoiceTotal += item.Quantity * item.PricePerUnit;
            }

            Console.WriteLine($"\nInvoice Total: ${invoiceTotal}\n");
        }
    }


}

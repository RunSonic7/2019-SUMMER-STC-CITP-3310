/*
    Week 8 - Assignment 3 - Total Sales (Arrays)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 28, 2019 at 11:59PM CDT
*/

using System;

namespace wk8assignment3TotalSales
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER_OF_PRODUCTS = 5;
            const int NO_OF_SALESPERSONS = 3;
            bool validator = false;
            double[,] sales = new double[NUMBER_OF_PRODUCTS, NO_OF_SALESPERSONS];
            double[] totalSalesProduct = new double[NUMBER_OF_PRODUCTS];
            double[] totalSalesSalesperson = new double[NO_OF_SALESPERSONS];
            double grandTotal = 0;

            Console.WriteLine("=======================================================");
            Console.WriteLine("================ SALES REPORT GENERATOR ===============");
            Console.WriteLine("=======================================================\n");

            // Accept Data into arrays
            for (int i = 0; i < NUMBER_OF_PRODUCTS; i++)
            {
                for (int j = 0; j < NO_OF_SALESPERSONS; j++)
                {
                    do
                    {
                        validator = false;
                        Console.Write($"Input Salesperson #{j + 1} sale amount for product {i + 1}:  $");

                        string input = Console.ReadLine();

                        if (double.TryParse(input, out double parsedInput) && parsedInput >= 0)
                        {

                            // Process to array
                            sales[i, j] = parsedInput;
                            validator = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input, Please Try Again");
                        }
                    } while (validator == false);

                }
                Console.WriteLine();
            }

            Console.WriteLine("================================================================================");
            Console.WriteLine("================================= SALES REPORT =================================");
            Console.WriteLine("================================================================================\n");

            string[] headers = { "Product No.", "Salesperson 1", "Salesperson 2", "Salesperson 3", "Product Total Sales", "\nSalesPrn Ttls" };

            Console.WriteLine($"{headers[0],-15}{headers[1],-15}{headers[2],-15}{headers[3],-15}{headers[4],20}");

            for (int i = 0; i < NUMBER_OF_PRODUCTS; i++)
            {
                Console.Write($"{i + 1,-15}");
                for (int j = 0; j < NO_OF_SALESPERSONS; j++)
                {
                    Console.Write($"{sales[i, j],-15:C}");

                    switch (i + 1)
                    {
                        case 1:
                            totalSalesProduct[0] += sales[i, j];
                            break;
                        case 2:
                            totalSalesProduct[1] += sales[i, j];
                            break;
                        case 3:
                            totalSalesProduct[2] += sales[i, j];
                            break;
                        case 4:
                            totalSalesProduct[3] += sales[i, j];
                            break;
                        case 5:
                            totalSalesProduct[4] += sales[i, j];
                            break;
                        default:
                            break;
                    }

                    switch (j + 1)
                    {
                        case 1:
                            totalSalesSalesperson[0] += sales[i, j];
                            break;
                        case 2:
                            totalSalesSalesperson[1] += sales[i, j];
                            break;
                        case 3:
                            totalSalesSalesperson[2] += sales[i, j];
                            break;
                        default:
                            break;

                    }
                }
                Console.Write($"{totalSalesProduct[i],20:C}");
                Console.WriteLine();
            }

            Console.Write($"{headers[5],-15}");

            // Calculate Salespersons individual sales.
            for (int k = 0; k < totalSalesSalesperson.Length; k++)
                Console.Write($"{totalSalesSalesperson[k],-15:C}");

            for (int m = 0; m < totalSalesSalesperson.Length; m++)
            {
                grandTotal += totalSalesSalesperson[m];
            }

            Console.Write($"{grandTotal,20:C}\n");

            Console.WriteLine($"\nGrand Total Sales: {grandTotal:C}");
        }
    }
}

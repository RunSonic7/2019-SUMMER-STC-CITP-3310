/*
    Week 8 - Assignment 2 - Airline Reservation System (Arrays)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 28, 2019 at 11:59PM CDT
*/

using System;

namespace wk8assignment2AirlineReservationSystem
{
    class Program
    {
        enum SeatTypes
        {
            FirstClass = 1,
            Economy = 2
        }
        static void Main(string[] args)
        {
            bool[] seatingChart = new bool[10];

            Console.WriteLine("=======================================================");
            Console.WriteLine("============= WELCOME  TO C SHARP AIRLINES ============");
            Console.WriteLine("=============== SEAT RESERVATION SYSTEM ===============");
            Console.WriteLine("=======================================================");

            bool seatFound = false;
            bool validator = false;

            // Validate User Input
            do
            {
                Console.WriteLine("\n+++++ SEAT TYPE SELECTION +++++");
                Console.WriteLine("Please enter your seat type (number) you wish to reserve.");
                Console.WriteLine("\n1 - First Class\n2 - Economy\n\n3 - EXIT\n\n");
                Console.Write("Your Selection:  ");

                string passengerSelection = Console.ReadLine();
                Tuple<int, bool, string> passengerSelectionProcessed = validatePassengerSelection(passengerSelection);


                if (passengerSelectionProcessed.Item2)
                {
                    // Check if open seat available in First Class
                    if (passengerSelectionProcessed.Item1 == (int)SeatTypes.FirstClass)
                    {
                        // Check seats 1 to 5
                        seatFound = checkFirstClass(seatingChart);

                        // If no seat is found in First Class
                        if (seatFound == false)
                        {
                            // Check if seat available in Economy
                            seatFound = checkEconomyClassAsk(seatingChart);

                            // If a seat is found in Economy
                            if (seatFound == true)
                            {
                                Console.WriteLine("\nWe apologize but we are sold out of First Class seats, \nhowever, we do have a seat open in Economy.  \nWould you like to book this seat?\nTo book, enter 2.");

                                string userInputAlternate = Console.ReadLine();

                                if (int.TryParse(userInputAlternate, out int parsedUserInputAlternate))
                                {
                                    if (parsedUserInputAlternate == 2)
                                    {
                                        // Book Seat in Economy
                                        bookEconomyClass(seatingChart);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nThe next flight leaves in 3 hours.\n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nThe next flight leaves in 3 hours.\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nWe apologize but we are fully booked. The next flight leaves in 3 hours.\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("*** Your First Class seat has been booked. ***");
                        }

                    }
                    else if (passengerSelectionProcessed.Item1 == (int)SeatTypes.Economy)
                    {
                        // Check Seats 6 to 10
                        seatFound = checkEconomyClass(seatingChart);

                        /// If no seat is found in Economy Class
                        if (seatFound == false)
                        {
                            // Check if seat available in First Class
                            seatFound = checkFirstClassAsk(seatingChart);

                            if (seatFound == true)
                            {
                                Console.WriteLine("\nNOTICE: We apologize but we are sold out of Economy Class seats, \nhowever, we do have a seat open in First Class.  \nWould you like to book this seat?\nTo book, enter 1.");

                                string userInputAlternate = Console.ReadLine();

                                if (int.TryParse(userInputAlternate, out int parsedUserInputAlternate))
                                {
                                    if (parsedUserInputAlternate == 1)
                                    {
                                        // Book Seat in First Class
                                        bookFirstClass(seatingChart);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nThe next flight leaves in 3 hours.\n");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nThe next flight leaves in 3 hours.\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nWe apologize but we are fully booked. The next flight leaves in 3 hours.\n");
                            }
                        }
                        else
                        {
                            Console.WriteLine("*** Your Economy seat has been booked. ***");

                        }
                    }
                }
                else
                {
                    validator = true;
                }


            } while (validator == false);
        }

        static bool checkFirstClass(bool[] seatingChartArray)
        {
            bool seatFound = false;
            for (int i = 0; i < 5; i++)
            {
                if (seatingChartArray[i] == false)
                {
                    seatingChartArray[i] = true;
                    seatFound = true;
                    Console.WriteLine("\nFOUND FIRST CLASS SEAT");
                    break;
                }
            }
            return seatFound;
        }

        static bool checkFirstClassAsk(bool[] seatingChartArray)
        {
            bool seatFound = false;
            for (int i = 0; i < 5; i++)
            {
                if (seatingChartArray[i] == false)
                {
                    //seatingChartArray[i] = true;
                    seatFound = true;
                    //Console.WriteLine("\nFound FC Seat - ASK");
                    break;
                }
            }
            return seatFound;
        }

        static bool checkEconomyClass(bool[] seatingChartArray)
        {
            bool seatFound = false;
            for (int i = 5; i < 10; i++)
            {
                if (seatingChartArray[i] == false)
                {
                    seatingChartArray[i] = true;
                    seatFound = true;
                    Console.WriteLine("\nFOUND ECONOMY SEAT");
                    break;
                }
            }
            return seatFound;
        }

        static bool checkEconomyClassAsk(bool[] seatingChartArray)
        {
            bool seatFound = false;
            for (int i = 5; i < 10; i++)
            {
                if (seatingChartArray[i] == false)
                {
                    //seatingChartArray[i] = true;
                    seatFound = true;
                    //Console.WriteLine("Found Eco Seat - ASK");
                    break;
                }
            }
            return seatFound;
        }

        static void bookFirstClass(bool[] seatingChartArray)
        {
            for (int i = 0; i < 5; i++)
            {
                if (seatingChartArray[i] == false)
                {
                    seatingChartArray[i] = true;
                    Console.WriteLine("*** Your First Class seat has been booked. ***\n");
                    break;
                }
            }
        }

        static void bookEconomyClass(bool[] seatingChartArray)
        {
            for (int i = 5; i < 10; i++)
            {
                if (seatingChartArray[i] == false)
                {
                    seatingChartArray[i] = true;
                    Console.WriteLine("*** Your Economy seat has been booked. ***\n");
                    break;
                }
            }
        }
        static Tuple<int, bool, string> validatePassengerSelection(string selection)
        {
            string message = "";
            bool validator = false;
            int number = int.TryParse(selection, out int parsedUserSelection) ? parsedUserSelection : 0;

            if (int.TryParse(selection, out int parsedSelection) == true)
            {
                if (parsedSelection >= 1 && parsedSelection <= 2)
                {
                    validator = true;
                }
                else
                {
                    message = "Your entry is invalid.";
                }
            }
            else
            {
                validator = false;
                message = "Your entry is invalid.";
            }
            return Tuple.Create(number, validator, message);
        }


    }
}

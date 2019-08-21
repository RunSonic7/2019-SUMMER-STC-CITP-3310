/*
    Week 7 - Assignment 2 - Guess the Number (Methods)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 21, 2019 at 11:59PM CDT
    Makeup work for illness
*/

using System;

namespace wk7assignment2GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            runGame();
        }

        static void runGame()
        {
            string playAgain = "";
            do
            {
                Console.WriteLine("=======================================================");
                Console.WriteLine("================ GUESS THE NUMBER GAME ================");
                Console.WriteLine("=======================================================\n");
                Console.WriteLine("Try to guess what the number is between 1 and 1000.\n");

                // Variables
                Random randomNumber = new Random();
                int correctNumber = randomNumber.Next(1, 1001);
                int tryCounter = 0;
                bool validator = false;
                int validUserInput = 0;
                string counterMessage =
                    tryCounter >= 10 ? $"You tried {tryCounter} times. That's a lot of tries!"
                        : tryCounter == 10 ? "Aha! You know the secret!"
                        : "You got lucky!";

                //Console.WriteLine(correctNumber);  // Use to help troubleshoot
                do
                {
                    // User Enter Guess
                    Console.Write("Enter your guess:   ");
                    string userInput = Console.ReadLine();

                    // Ensure entry is valid
                    if (int.TryParse(userInput, out int parsedUserInput))
                    {
                        if (parsedUserInput >= 1 && parsedUserInput <= 1000)
                        {
                            validUserInput = parsedUserInput;

                            Tuple<string, bool> determination = determineIfWinner(parsedUserInput, correctNumber);
                            Console.WriteLine(determination.Item1);
                            validator = determination.Item2;

                            tryCounter++;
                        }
                        else
                        {
                            Console.WriteLine("Your Input was invalid.  Please Try Again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your Input was invalid.  Please Try Again.");
                    }
                } while (validator == false);

                // Display counter message and ask if user wants to play again 
                Console.WriteLine(counterMessage);
                Console.WriteLine("\nWould you like to play again? Enter \"N\" or \"n\" for No and any character for Yes.");
                playAgain = Console.ReadLine();
            } while (playAgain != "N" && playAgain != "n");
        }

        /* Sources x
        https://stackoverflow.com/questions/748062/return-multiple-values-to-a-method-caller
        https://docs.microsoft.com/en-us/dotnet/api/system.tuple?redirectedfrom=MSDN&view=netframework-4.8
        */

        // Determine if number is a winner
        static Tuple<string, bool> determineIfWinner(int value, int winningNumber)
        {
            string message = value < winningNumber
                ? "Your guess is too low.\n"
                : value > winningNumber
                    ? "Your guess is too high.\n"
                    : "YOU GUESSED CORRECTLY! YOU WIN!";


            bool validator = value < winningNumber
                ? false
                : value > winningNumber
                    ? false
                    : true;

            return Tuple.Create(message, validator);
        }
    }
}

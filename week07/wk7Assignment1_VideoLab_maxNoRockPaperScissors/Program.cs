/*
    Week 7 - Assignment 1 - Video Lab - Max Number | Rock-Paper-Scissors (Methods)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 21, 2019 at 11:59PM CDT
    Makeup work for illness
*/

using System;

namespace wk7videoLab
{
    class Program
    {
        private enum sel
        {
            Paper = 1,
            Scissors = 2,
            Rock = 3
        }
        static void Main(string[] args)
        {
            Welcome();
        }

        static void Welcome()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("* Welcome to the Methods! *");
            Console.WriteLine("***************************");

            int userMenu = MainMenu();
            switch (userMenu)
            {
                case 1:
                    Maximum();
                    break;
                case 2:
                    Game();
                    break;

            }
        }

        static int MainMenu()
        {
            while (true)
            {
                const int MENU_SIZE = 2;
                Console.WriteLine("\n\nPlease Select an Option");
                Console.WriteLine("1.- Max Number");
                Console.WriteLine("2. Play Paper, Scissors, Rock");
                int selection = int.Parse(Console.ReadLine());

                if (selection > 0 && selection <= MENU_SIZE)
                {
                    return selection;
                }
            }

        }

        static void Maximum()
        {
            Console.WriteLine("Get the Maximum number of a series of numbers.");
            Console.WriteLine("Provide me with the first Number:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Provide me with the second Number:");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Provide me with the third Number:");
            int third = int.Parse(Console.ReadLine());

            //int maxNumber = getMaxNumber(first, second, third);
            // stopped at 34:30

            Console.WriteLine($"The Max number is {getMaxNumber(first, second, third)}");

            Console.WriteLine($"The Max number is {getMaxNumb(first, second, third)}");
        }

        static int getMaxNumber(int x, int y, int z)
        {
            int maxNumber = x;

            if (y > maxNumber)
            {
                maxNumber = y;
            }
            if (z > maxNumber)
            {
                maxNumber = z;
            }
            return maxNumber;
        }

        static int getMaxNumb(int x, int y, int z)
        {
            int maxNumber =
            x > y && x > z
              ? x
              : y > x && y > z
                ? y
                : z;
            return maxNumber;
        }

        static int getMax(int x, int y, int z) => x > y && x > z ? x : y > x && y > z ? y : z;

        static void Game()
        {
            Random randomNumber = new Random();
            Console.WriteLine("Welcome to Paper(1), Scissors(2), Rock(3)Game!\nPlease choose your weapon:");

            int user = int.Parse(Console.ReadLine());

            int computer = randomNumber.Next(1, 4);

            Console.WriteLine($"Computer Selected {(sel)computer}");

            // Console.WriteLine($"User Selected {(sel) user}");

            switch ((sel)user)
            {
                case sel.Paper when (sel)computer == sel.Rock:
                case sel.Scissors when (sel)computer == sel.Paper:
                case sel.Rock when (sel)computer == sel.Scissors:
                    Console.WriteLine("User Won!!");
                    break;
                case sel.Paper when (sel)computer == sel.Paper:
                case sel.Scissors when (sel)computer == sel.Rock:
                case sel.Rock when (sel)computer == sel.Paper:
                    Console.WriteLine("Computer Won!!");
                    break;
                case sel.Paper when (sel)computer == sel.Paper:
                case sel.Scissors when (sel)computer == sel.Scissors:
                case sel.Rock when (sel)computer == sel.Rock:
                    Console.WriteLine("It is a tie!!");
                    break;
            }
        }

    }
}

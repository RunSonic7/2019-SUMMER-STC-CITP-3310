/*
    Week 3 - Assignment 1 - Video Lab - Classes and Objects
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, June 23, 2019 at 11:59PM CDT
*/

using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the objects
            Person john = new Person("John", "Smith", 21);
            Person juan = new Person("Juan", "Perez", 15);
            Person juanm = new Person("Juan", "Mireles II", 29);

            john.PrintName();
            juan.PrintName();
            juanm.PrintName();

            Console.WriteLine(john.Age);
            Console.WriteLine(juan.Age);
            Console.WriteLine(juanm.Age);

            //Console.WriteLine(john.Age);
            // string name = john.First;
            // Console.WriteLine(name);
        }
    }

    // Declare the class (generally is in a separate file)
    class Person
    {
        // Declare properties and get/set
        public string First { get; set; }
        public string Last { get; set; }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age should be a positive number");
                }
            }
        }

        // Constructor
        public Person(string firstName, string lastName, int theAge)
        {
            First = firstName;
            Last = lastName;
            Age = theAge;
        }

        // Methods
        public void PrintName()
        {
            Console.WriteLine($"My name is {First} {Last}. I am {Age} years old");
        }
    }
}

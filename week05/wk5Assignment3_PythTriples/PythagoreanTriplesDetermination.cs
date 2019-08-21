/*
    Week 5 - Assignment 3 - Pythagorean Triples (Control Statements Part 2)
    Name: Juan Mireles II
    Course: CITP 3310.V20 - Survey of Programming Languages
    Semester: Summer III 2019
    Due Date: Sunday, July 7, 2019 at 11:59PM CDT
    Makeup Work due to illness
*/

using System;
using System.Collections.Generic;

namespace wk05_assignment3_pythagoreanTriples
{
    class PythagoreanTriplesDetermination
    {
        static void Main(string[] args)
        {
            List<Triples> pythagoreanTriples = new List<Triples>();
            //Triples triple = new Triples(5, 5, 5);

            //Console.WriteLine(triple.SideA);

            int a;
            int b;
            int c;

            for (a = 3; a < 800; a++)
            {
                for (b = 4; b < 800; b++)
                {
                    for (c = 5; c < 800; c++)
                    {
                        if (a * a + b * b == c * c)
                        {
                            pythagoreanTriples.Add(new Triples(a, b, c));
                        }
                    }
                }
            }

            foreach (Triples pythTriple in pythagoreanTriples)
            {
                Console.Write($"({pythTriple.SideA},{pythTriple.SideB},{pythTriple.SideC}),");
            }
        }
    }
}

using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== TRIANGLE TYPE IDENTIFIER =====");

            Console.Write("Enter length of side 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter length of side 2: ");
            string input2 = Console.ReadLine();
            Console.Write("Enter length of side 3: ");
            string input3 = Console.ReadLine();

            double side1, side2, side3;

            if (double.TryParse(input1, out side1) &&
                double.TryParse(input2, out side2) &&
                double.TryParse(input3, out side3))
            {
                if (side1 + side2 > side3 &&
                    side1 + side3 > side2 &&
                    side2 + side3 > side1)
                {
                    if (side1 == side2 && side2 == side3)
                    {
                        Console.WriteLine("This is an Equilateral triangle.");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("This is an Isosceles triangle.");
                    }
                    else
                    {
                        Console.WriteLine("This is a Scalene triangle.");
                    }
                }
                else
                {
                    Console.WriteLine("The given sides do not form a valid triangle.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

using System;

class TriangleTypeIdentifier
{
    static void Main(string[] args)
    {
        Console.WriteLine("Triangle Type Identifier");
        Console.Write("Enter the length of side 1: ");
        if (!double.TryParse(Console.ReadLine(), out double side1) || side1 <= 0)
        {
            Console.WriteLine("Invalid input. Side length must be a positive number.");
            return;
        }

        Console.Write("Enter the length of side 2: ");
        if (!double.TryParse(Console.ReadLine(), out double side2) || side2 <= 0)
        {
            Console.WriteLine("Invalid input. Side length must be a positive number.");
            return;
        }

        Console.Write("Enter the length of side 3: ");
        if (!double.TryParse(Console.ReadLine(), out double side3) || side3 <= 0)
        {
            Console.WriteLine("Invalid input. Side length must be a positive number.");
            return;
        }

        // Check if it's a valid triangle
        if (side1 + side2 <= side3 || side2 + side3 <= side1 || side1 + side3 <= side2)
        {
            Console.WriteLine("These side lengths cannot form a valid triangle.");
            return;
        }

        string triangleType;
        if (side1 == side2 && side2 == side3)
        {
            triangleType = "Equilateral";
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            triangleType = "Isosceles";
        }
        else
        {
            triangleType = "Scalene";
        }

        Console.WriteLine($"Triangle Type: {triangleType}");
    }
}
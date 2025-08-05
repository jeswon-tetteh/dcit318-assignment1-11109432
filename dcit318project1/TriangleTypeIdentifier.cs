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

        // Check if it's a valid triangle with specific error messages
        if (side1 + side2 <= side3)
        {
            Console.WriteLine($"Invalid triangle: Side1 ({side1}) + Side2 ({side2}) <= Side3 ({side3}). Sum must be greater than the third side.");
            return;
        }
        if (side2 + side3 <= side1)
        {
            Console.WriteLine($"Invalid triangle: Side2 ({side2}) + Side3 ({side3}) <= Side1 ({side1}). Sum must be greater than the first side.");
            return;
        }
        if (side1 + side3 <= side2)
        {
            Console.WriteLine($"Invalid triangle: Side1 ({side1}) + Side3 ({side3}) <= Side2 ({side2}). Sum must be greater than the second side.");
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

        double perimeter = side1 + side2 + side3;

        Console.WriteLine($"Triangle Type: {triangleType}");
        Console.WriteLine($"Perimeter: {perimeter:F2} units");
    }
}
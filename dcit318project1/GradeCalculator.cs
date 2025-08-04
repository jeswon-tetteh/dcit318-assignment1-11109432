using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Calculator");
        Console.Write("Enter a numerical grade (0-100): ");

        if (!double.TryParse(Console.ReadLine(), out double grade) || grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid input. Grade must be between 0 and 100.");
            return;
        }

        string letterGrade = grade switch
        {
            >= 90 => "A",

            >= 80 => "B",

            >= 70 => "C",

            >= 60 => "D",

            _ => "F"
        };

        Console.WriteLine($"Letter Grade: {letterGrade}");
    }
}

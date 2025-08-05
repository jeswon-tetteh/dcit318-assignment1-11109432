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

         string message = letterGrade switch
        {
            "A" => "Excellent work! Keep it up!",
            "B" => "Great job, you're doing well!",
            "C" => "Good effort, there's room for improvement.",
            "D" => "You passed, but let's aim higher next time.",
            _ => "Don't give up, you can improve with more practice!"
        };

        Console.WriteLine($"Letter Grade: {letterGrade}");
        Console.WriteLine($"Message: {message}");
    }

}

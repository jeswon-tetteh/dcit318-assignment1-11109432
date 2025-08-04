
using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ticket Price Calculator");
        Console.Write("Enter your age: ");

        if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
        {
            Console.WriteLine("Invalid input. Age must be a non-negative number.");
            return;
        }

        decimal ticketPrice = (age <= 12 || age >= 65) ? 7.00m : 10.00m;
        Console.WriteLine($"Ticket Price: GHC{ticketPrice:F2}");
    }
}

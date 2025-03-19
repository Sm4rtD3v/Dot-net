using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giveaway time!");
            Console.Write("Choose a number: ");
            string? userChoice = Console.ReadLine();
            string message = "";
            if (userChoice == "1")
                message = "won a car";
            else if (userChoice == "2")
                message = "won a boat";
            else if (userChoice == "3")
                message = "won a plane";
            else
                message = "didn't win anything";
            Console.WriteLine("You {0}!", message);
        }
    }
}
using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(myFirstName))
            {
                myFirstName = "John";
            }

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(myLastName))
            {
                myLastName = "Doe";
            }

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + "!");
        }
    }
}
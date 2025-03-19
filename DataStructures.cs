using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Abraham Lincoln", "Bruce Lee", "Christopher Nolan", "Hans Zimmer" };
            string welcomeMsg = "Choose option 1 if you want to search for a name and choose option 2 if you want to reverse a word: ";
            Console.Write(welcomeMsg);
            string choice = Console.ReadLine()!;
            while (choice != "1" && choice != "2")
            {
                Console.WriteLine("Invalid choice, try again!");
                Console.Write(welcomeMsg);
                choice = Console.ReadLine()!;
            }
            if (choice == "1")
            {
                Console.Write("Enter a name to search for: ");
                string nameToSearch = Console.ReadLine()!;
                bool isFound = false;
                foreach (string name in names)
                {
                    if (name.Contains(nameToSearch))
                    {
                        isFound = true;
                        Console.WriteLine(name);
                        break;
                    }
                }
                if (!isFound)
                {
                    Console.WriteLine(nameToSearch + " was not found!");
                }
            }
            else
            {
                Console.Write("Enter a word to reverse: ");
                string wordToReverse = Console.ReadLine()!;
                char[] charArray = wordToReverse.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(new string(charArray));
            }
        }
    }
}
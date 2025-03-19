using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split();
            int[] input = new int[inputString.Length];
            for (int i = 0; i < inputString.Length; i++)
            {
                input[i] = int.Parse(inputString[i]);
            }

            for (int i = 1; i <= input[2]; i++)
            {
                if (i % input[0] == 0 && i % input[1] == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % input[0] == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % input[1] == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
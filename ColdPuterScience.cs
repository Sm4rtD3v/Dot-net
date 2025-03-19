using System;

namespace ColdPuterScience
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] inputString = Console.ReadLine().Split();
            int[] input = new int[inputString.Length];
            for (int i = 0; i < inputString.Length; i++)
            {
                input[i] = int.Parse(inputString[i]);
            }

            int negNbrCount = 0;
            foreach (int temperature in input)
            {
                if (temperature < 0)
                {
                    negNbrCount++;
                }
            }
            Console.WriteLine(negNbrCount);
        }
    }
}
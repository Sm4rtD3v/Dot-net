using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 50; i++)
            {
                bool isPrime = true;
                for (int x = 2; x <= Math.Sqrt(i); x++)
                {
                    if (i % x == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {           
                    Console.WriteLine(i);
                }
            }
        }
    }
}
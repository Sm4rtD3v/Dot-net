using System;

namespace MathProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine() ?? "0");
            int y = x + 3;
            Console.WriteLine(y);
        }
    }
}
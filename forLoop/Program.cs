using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = 5;

            for (int i = iterations; i > 0 ; i--)
            {
                Console.Write($"{i} ");
            }
        }
    }
}

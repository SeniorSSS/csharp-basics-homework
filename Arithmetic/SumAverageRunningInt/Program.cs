using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            int average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number) {
                sum += number;
            }

            Console.WriteLine("The sum of {0} to {1} is {3}", lowerBound, upperBound, sum);
            Console.ReadKey();
        }
    }
}

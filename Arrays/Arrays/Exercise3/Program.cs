using System;
using System.Diagnostics.CodeAnalysis;

namespace Exercise3
{
    class Program
    {
        //TODO: Write a C# program to calculate the average value of array elements.
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};

            /*
            fixme - calculate sum of all array elements 
            int sum = 0;
            for (?){
                
            }
            */
            int sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            /*
            fixme - calculate average value 
            Console.WriteLine("Average value of the array elements is : " + average);
            */
            Console.WriteLine("Videja vertiba = {0:F2}", (decimal)sum/numbers.Length);
            Console.ReadKey();
        }
    }
}

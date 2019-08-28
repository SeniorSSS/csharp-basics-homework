using System;


namespace LoopsExercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            int i, n, result;

           Console.WriteLine("Input number of terms : ");

           n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input i : ");

            i = Convert.ToInt32(Console.ReadLine());

            result = i;

            /*
            todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            for (.......) {
              Console.WriteLine(........);
            }
            */


            for (var a = 2; a <= i; a++)
            {
                result *= i;
            }

            Console.WriteLine("Rezultåts {0}", result);
        }
    }
}


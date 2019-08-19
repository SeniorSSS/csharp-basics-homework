using System;

namespace Exercise6
{
    class Program
    {
        static string PrintArray(int[] arr)
        {
            string result = "";
            foreach (int item in arr)
            {
                result += item.ToString() + ' ';
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] firstArray = new int[10];
            int[] secondArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                firstArray[i] = rnd.Next(1, 101);
            }

            secondArray = firstArray;

            Console.WriteLine("Array1 {0}", PrintArray(firstArray));
            Console.WriteLine("Array2 {0}", PrintArray(secondArray));

            Console.ReadKey();
        }
    }
}

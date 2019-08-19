using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Program
    {
        //TODO: Write a C# program to sort a numeric array and a string array.

        static string printArray(int[] arr)
        {
            string result = "";
            foreach (int item in arr)
            {
                result += item.ToString() + ' ';
            }
            return result;
        }

        static string printArray(string[] arr)
        {
            string result = "";
            foreach (string item in arr)
            {
                result += item.ToString() + ' ';
            }
            return result;
        }

        private static void Main(string[] args)
        {



            int[] myArray1 = {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2165, 1457, 2456
            };

            string[] myArray2 = {
                "Java",
                "Python",
                "PHP",
                "C#",
                "C Programming",
                "C++"
            };

            
            Console.WriteLine("Original numeric array : " + printArray(myArray1));
            Array.Sort(myArray1);//Sort array
            Console.WriteLine("Sorted numeric array : " + printArray(myArray1));
    
            Console.WriteLine("Original string array : " + printArray(myArray2));
//             Array.Sort(myArray2);//Sort array
            var myarray3 = myArray2;
            Array.Sort(myarray3);
            var sortArray = myArray2.OrderBy(n => n);
            Console.Write("Sorted string array : ");
            foreach (var item in sortArray)
            {
                Console.Write(item + ' ');
            }
            Console.WriteLine(" ");
            Console.WriteLine("Sort string array : " + printArray(myarray3));

            Console.ReadKey();
        }
    }
}

using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());
        
            /*
            todo - expected output:
            Input the 1st number: 25
            Input the 2nd number: 78
            Input the 3rd number: 87
        
             */
            int largest1 = 0;

            if (input1 > input2)
            {
                if (input1 > input3)
                {
                    largest1 = input1;
                }
            }
            else if (input2 > input3)
                {
                    largest1 = input2;
                }
                else
                {
                    largest1 = input3;
                }
            


            Console.WriteLine("Lielakais no skaitliem {0} {1} {2} ir {3}",input1, input2, input3, largest1);
                Console.ReadKey();
        }
    }
}

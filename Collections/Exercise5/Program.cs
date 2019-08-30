using System;
using System.Collections;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi skaitli: ");
            var charNumbers = Console.ReadLine().ToCharArray();
            var stack = new Stack();

            for (var i = 0; i < charNumbers.Length; i++)
            {
                stack.Push(charNumbers[i]);
            }

            do
            {


                var result = 0;
                while (stack.Count > 0)
                {
                    int number = Int32.Parse(stack.Pop().ToString());
                    result += number * number;
                }

                charNumbers = result.ToString().ToCharArray();

                for (var i = 0; i < charNumbers.Length; i++)
                {
                    stack.Push(charNumbers[i]);
                }



            } while (stack.Count>1);

            //Console.WriteLine(result);
            if (stack.Pop().ToString() == "1")
            {
                Console.WriteLine("Skaitlis Laimigs");
            }
            else
            {
                Console.WriteLine("Skaitlis NAV laimigs");
            }


                Console.ReadKey();
        }
    }
}

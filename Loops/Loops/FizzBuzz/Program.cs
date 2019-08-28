using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadi skaitli:");
            int n = Convert.ToInt32(Console.ReadLine());


            for (var i = 1; i <= n; i++)
            {
                string res = "";
                bool fizz = false;
                if (i % 3 == 0)
                {
                    res += "Fizz";
                    fizz = true;
                }
                if (i % 5 == 0)
                {
                    res += "Buzz";
                    fizz = true;
                }

                if (!fizz)
                {
                    res = i.ToString();
                }

                Console.Write(res + ' ');
            }

            Console.ReadKey();
        }
    }
}

using System;

namespace NumberSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Min? :");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Max? :");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (var i = 0; i <= max - min; i++)
            {
                for (var j = min; j <= max; j++)
                {
                     
                    Console.Write(j + i > max ? j + i - max + min - 1 : j + i);
                }
                Console.WriteLine("");
            }



            Console.ReadKey();
        }
    }
}

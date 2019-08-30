using System;
using Exercise5;

namespace ConsoleReadKey1
{
    class Program
    {
        static void Main(string[] args)
        {
            var datums = new Date(18, 02, 1977);
            datums.DisplayDate();

            Console.ReadKey();
        }
    }
}

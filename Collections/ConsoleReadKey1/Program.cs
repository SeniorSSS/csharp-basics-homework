using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleReadKey1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            var name = "";

            do
            {
                name = Console.ReadLine();
                names.Add(name);

            } while (name != "");

            
            Console.WriteLine(string.Join(" ", names));

            Console.ReadKey();
        }
    }
}

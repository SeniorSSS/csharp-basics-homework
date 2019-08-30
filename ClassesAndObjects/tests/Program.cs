using System;

namespace tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;

            for (var i = N; i > 0; i--)
            {
                string result = "";
                Console.WriteLine(result.PadLeft(i,char.Parse(N.ToString())));
            }
                Console.ReadKey();
        }
    }
}

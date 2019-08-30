using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
            string[] inputs = Console.ReadLine().Split(' ');
            int closest = 0;
            bool init = false;

            for (int i = 0; i < n; i++)
            {
                int t = int.Parse(inputs[i]);// a temperature expressed as an integer ranging from -273 to 5526
                if (!init)
                {
                    closest = t;
                    init = true;
                    continue;
                }
                if (Math.Abs(t) < Math.Abs(closest))
                {
                    closest = t;
                } else
                {
                    if (Math.Abs(t) == Math.Abs(closest))
                    {
                        if (t>0)
                        {
                            closest = t;
                        }
                    }
                }
            }

            var result = 0;

            if (n != 0)
            {
                result = closest;
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}

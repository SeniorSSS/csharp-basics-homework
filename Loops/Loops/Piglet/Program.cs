using System;

namespace Piglet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spele sakas!");

            int sum = 0;
            string answer = "";

            do
            {
                Random rnd = new Random();
                int dice = rnd.Next(1, 7);
                Console.WriteLine("Uzmeti {0}",dice);
                if (dice == 1)
                {
                    sum = 0;
                    break;
                }

                sum += dice;

                Console.Write("Metisi velreiz? (y/n)? : ");
                Console.WriteLine("");
                answer = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine("");

            } while (answer != "n");
            Console.WriteLine("Tavs rezultats ={0}", sum);
            Console.ReadKey();
        }
    }
}

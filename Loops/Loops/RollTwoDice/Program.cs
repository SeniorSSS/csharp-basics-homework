using System;

namespace RollTwoDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kadu summu velies? : ");
            int desireSum = Convert.ToInt32(Console.ReadLine());
            int sum;
            do
            {
                Random rnd = new Random();
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                sum = dice1 + dice2;
                Console.WriteLine("{0} un {1} = {2}",dice1, dice2, sum);


            } while (sum != desireSum);


                Console.ReadKey();
        }
    }
}

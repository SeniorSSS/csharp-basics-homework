using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Zed A. Shaw";
            int age = 35;
            double height = 74 * 2.54;  // cm
            double weight = 180 * 0.453592; // kg
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";

            Console.WriteLine("Let's talk about {0}.", name);
            Console.WriteLine("He's {0:F2} inches tall.", height);
            Console.WriteLine("He's {0:F2} pounds heavy.", weight);
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got {0} eyes and {1} hair.", eyes, hair);
            ////Console.WriteLine("His teeth are usually {0} depending on the coffee.", teeth);

            Console.WriteLine("If I add {0}, {1:F2}, and {2:F2} I get {3:F2}.", age, height, weight, (age + height + weight));
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
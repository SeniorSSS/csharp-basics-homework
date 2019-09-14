using System;
using System.Linq;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
/*            var mouse1 = new Cat("Kaķis", "Micky Mouse", "Siāmas", 12.4, 5, "Latvia");
            var food1 = new Meat(3);

            mouse1.EatFood(food1);

            Console.WriteLine(mouse1.ToString());*/

            var feeding = new Feeding();

            do
            {
                Console.Write("Ievadi dzīvnieku:");
                string[] input = Console.ReadLine().Split(' ');

                if (input[0] == "End")
                {
                    break;
                }

                if (input[0] == "Cat")
                {
                    feeding.AddAnimal(new Cat(input[0], input[1], input[2], Double.Parse(input[3]), input[4]));
                }
                if (input[0] == "Tiger")
                {
                    feeding.AddAnimal(new Tiger(input[0], input[1], Double.Parse(input[2]), input[3]));
                }
                if (input[0] == "Mouse")
                {
                    feeding.AddAnimal(new Mouse(input[0], input[1], Double.Parse(input[2]), input[3]));
                }
                if (input[0] == "Zebra")
                {
                    feeding.AddAnimal(new Zebra(input[0], input[1], Double.Parse(input[2]), input[3]));
                }

                feeding.FeedinAnimals.ElementAt(feeding.AnimalCount - 1).MakeSound();


                Console.Write("Barība: ");
                string[] food = Console.ReadLine().Split(' ');

                if (food[0] == "Meat")
                {
                    feeding.FeedinAnimals.ElementAt(feeding.AnimalCount - 1).EatFood(new Meat(Int32.Parse(food[1])));
                } else if (food[0] == "Vegitable")
                {
                    feeding.FeedinAnimals.ElementAt(feeding.AnimalCount - 1).EatFood(new Vegetable(Int32.Parse(food[1])));
                }

            } while (true);

            if (feeding.AnimalCount > 0)
            {
                Console.WriteLine(feeding.ToString());
            }

            Console.ReadKey();
        }
    }
}

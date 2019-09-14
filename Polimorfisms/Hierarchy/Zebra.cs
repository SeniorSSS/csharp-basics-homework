using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Zebra : Mammal
    {
        private string _eats;

        public Zebra(string animalType, string name, double animalWeight, string livingRegion) : base(animalType, name, animalWeight, livingRegion)
        {
            _eats = "Vegatable";
        }
        public override void MakeSound()
        {
            Console.WriteLine(">dipadu dapadu");
        }

        public override void EatFood(Food foodToEat)
        {
            if (foodToEat.FoodType() == _eats)
            {
                FoodEaten += foodToEat.Quantity;
            }
            else
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }
        }

        public override string ToString()
        {
            var toPrint = $"{AnimalType} [{AnimalName} {AnimalWeight}kg {LivingRegion} {FoodEaten}]";
            return toPrint;
        }
    }
}

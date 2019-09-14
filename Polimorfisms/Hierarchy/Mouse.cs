using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        private string _eats;
        //private Food _eatFood;

        public Mouse(string animalType, string name, double animalWeight, string livingRegion) : base(animalType, name, animalWeight, livingRegion)
        {
            _eats = "Vegatable";
        }

        public override void MakeSound()
        {
            Console.WriteLine(">pipipi");
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

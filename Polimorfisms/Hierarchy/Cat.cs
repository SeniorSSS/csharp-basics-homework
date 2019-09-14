using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Cat : Felime
    {
        private string _breed;
        public Cat(string animalType, string name, string breed, double animalWeight, string livingRegion) : base(animalType, name, animalWeight, livingRegion)
        {
            _breed = breed;
        }
        public override void MakeSound()
        {
            Console.WriteLine(">Mjau");
        }

        public string Breed
        {
            get => _breed;
        }

        public override void EatFood(Food foodToEat)
        {
            FoodEaten += foodToEat.Quantity;

        }

        public override string ToString()
        {
            var toPrint = $"{AnimalType} [{AnimalName} {Breed} {AnimalWeight}kg {LivingRegion} {FoodEaten}]";
            return toPrint;
        }
    }
}

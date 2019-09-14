using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        private string _livingRegion;

        public Mammal(string animalType, string name, double animalWeight, string livingRegion) : 
                 base(animalType, name, animalWeight)
        {
            _livingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get => _livingRegion;
        }



    }
}

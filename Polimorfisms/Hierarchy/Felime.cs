using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Felime: Mammal
    {
        public Felime(string animalType, string name, double animalWeight, string livingRegion) :
            base(animalType, name, animalWeight, livingRegion)
        {
        }

    }
}

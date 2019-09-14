using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Feeding
    {
        private List<Animal> _feedingAnimals;

        public List<Animal> FeedinAnimals
        {
            get => _feedingAnimals;
            set => _feedingAnimals = value;
        }

        public Feeding()
        {
            FeedinAnimals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            FeedinAnimals.Add(animal);
        }

        public int AnimalCount
        {
            get => _feedingAnimals.Count;
        }

        public override string ToString()
        {
            List<string> toPrintList = new List<string>();
            foreach (var animal in _feedingAnimals)
            {
                toPrintList.Add(animal.ToString());
            }

            return string.Join(", ", toPrintList);
        }
    }
}

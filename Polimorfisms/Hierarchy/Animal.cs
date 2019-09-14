using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Animal
    {
        private string _name;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten;

        public Animal(string animalType, string name, double animalWeight)
        {
            _name = name;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = 0;
        }

        public int FoodEaten
        {
            get => _foodEaten;
            set => _foodEaten = value;
        }

        public string AnimalType
        {
            get => _animalType;
        }

        public string AnimalName
        {
            get => _name;
        }

        public double AnimalWeight
        {
            get => _animalWeight;
        }

        public abstract void MakeSound();

        public abstract void EatFood(Food foodToEat);

        public abstract override string ToString();

    }
}

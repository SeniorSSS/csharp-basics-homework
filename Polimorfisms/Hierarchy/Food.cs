using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Food
    {
        private int _quantity;
        private string _name;

        public Food(int quantity)
        {
            _quantity = quantity;
        }

        public int Quantity
        {
            get => _quantity;
        }

        public abstract string FoodType();

    }
}

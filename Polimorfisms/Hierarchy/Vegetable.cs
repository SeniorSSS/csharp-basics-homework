using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Vegetable : Food
    {
        private string _name;
        public Vegetable(int quantity) : base(quantity)
        {
            _name = "Vegatable";
        }

        public override string FoodType()
        {
            return _name;
        }

    }
}

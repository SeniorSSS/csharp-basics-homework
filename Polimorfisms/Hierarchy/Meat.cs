using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Meat : Food
    {
        private string _name;
        public Meat(int quantity) : base(quantity)
        {
            _name = "Meat";
        }

        public override string FoodType()
        {
            return _name;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AddAp
{
    class Poster : Advert
    {
        private int _width;
        private int _height;
        private int _numberOfCopies;
        private int _costPerCopy;

        public Poster(int fee, int width, int height, int numberOfCopies, int costPerCopy) : base(fee)
        {
            _width = width;
            _height = height;
            _numberOfCopies = numberOfCopies;
            _costPerCopy = costPerCopy;
        }

        public new int Cost()
        {
            return base.Cost() + _costPerCopy * _numberOfCopies;
        }

        public override string ToString()
        {
            return base.ToString()
                   + " Poster dimensions width x height (cm) = " + _width + " x " + _height
                   + " number of copies = " + _numberOfCopies;
        }
    }
}

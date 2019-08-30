using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise9
{
    class Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Point(Point temp)
        {
            _x = temp._x;
            _y = temp._y;
        }

        public int x
        {
            get { return _x; }
        }

        public int y
        {
            get { return _y; }
        }

    }
}

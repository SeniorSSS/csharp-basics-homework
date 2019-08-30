using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }
        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public void DisplayDate()
        {
            Console.Write($"{Day}/{Month}/{Year}");
        }

    }
}

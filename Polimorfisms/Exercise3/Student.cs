using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Student : Person
    {
        private double _gpa;
        public Student(string firstName, string lastName, string address, int id, double gpa) : base(firstName, lastName, address, id)
        {
            _gpa = gpa;
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }
        public override void display()
        {
            Console.Write($"{Gpa} ");
            base.display();
        }
    }
}

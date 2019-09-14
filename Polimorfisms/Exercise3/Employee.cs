﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    internal class Employee : Person
    {
        private string _jobTitle;
        public Employee(string firstName, string lastName, string address, int id, string jobTitle) : base(firstName, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }

        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        public override void display()
        {
            Console.Write($"{JobTitle} ");
            base.display();
        }
    }
}

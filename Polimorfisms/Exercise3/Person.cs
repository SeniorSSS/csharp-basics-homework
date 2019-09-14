using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual void display()
        {
            Console.WriteLine($"{ID} {FirstName} {LastName} {Address}");
        }

    }
}

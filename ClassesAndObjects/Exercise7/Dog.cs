using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class Dog
    {
        private string _name;
        private string _sex;
        private Dog _mother;
        private Dog _father;

        public Dog(string name, string sex, Dog father, Dog mother)
        {
            _name = name;
            _sex = sex;
            _father = father;
            _mother = mother;
        }

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }

        public string FatherName()
        {
            return (_father == null) ? "Unknown" : _father._name;
        }

        public bool HasSameMotherAs(Dog dog)
        {
            if (_mother != null && dog._mother != null)
            {
                return _mother == dog._mother ? true : false;
            }
            else
            {
                return false;
            }
        }
    }
}

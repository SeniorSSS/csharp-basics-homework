using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    class PhoneDirectoryList
    {
        private SortedDictionary<string, string> _phoneBook;


        public PhoneDirectoryList()
        {
            _phoneBook = new SortedDictionary<string, string>();
        }

        private bool Find(string name)
        {
            if (_phoneBook.ContainsKey(name))
            {
                return true;
            }
            return false;
        }

        public string GetNumber(string name)
        {
            if (!Find(name))
            {
                return null;
            }
            else
            {
                return _phoneBook[name];
            }
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }

            if (Find(name))
            {
                _phoneBook[name] = number;
            }
            else
            {
                _phoneBook.Add(name, number);
            }
        }

        public void DeleteNumber(string name)
        {

        }

        public void PrintPhone(string name)
        {
            if (Find(name))
            {
                Console.WriteLine($"{name} {_phoneBook[name]}");
            }
        }
        public void PrintPhoneBook()
        {
            Console.WriteLine("-========Phone Book=======-");
            foreach (KeyValuePair<string, string> phone in _phoneBook)
            {
                PrintPhone(phone.Key);
            }
            Console.WriteLine("-=========================-");
        }
    }
}

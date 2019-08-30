using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private string _name;
        private decimal _money;

        public Account(string name, decimal money)
        {
            _name = name;
            _money = money;
        }


        public decimal withdrawal(decimal i)
        {
            _money -= i;
            return i;
        }

        public decimal balance()
        {
            return _money;
        }

        public void deposit(decimal i)
        {
            _money += i;
        }

        public override string ToString()
        {
            return $"{_name} - {_money}";
        }
    }
}

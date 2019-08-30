using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        private string _name;
        private double _balance;

        public Account (string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public void ShowUserNameAndBalance()
        {
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            culture.NumberFormat.CurrencyNegativePattern = 1;
            String signBalance = String.Format(culture, "{0:C2}", _balance);
            Console.WriteLine($"{_name}, {signBalance:C2}");
        }
    }
}

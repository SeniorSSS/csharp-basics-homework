using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    class SavingsAccount
    {
        private int _interest;
        private decimal _balance;
        private decimal _startingBalance;
        private decimal _totalDeposited;
        private decimal _totalwithDrawal;
        private decimal _totalInterest;


        public SavingsAccount(int interest, decimal balance)
        {
            _interest = interest;
            _balance = balance;
            _startingBalance = _balance;
            _totalDeposited = balance;
            _totalInterest = 0;
            _totalwithDrawal = 0;
        }

        public void withDrawal(decimal money)
        {
            _balance -= money;
            _totalwithDrawal += money;
        }

        public void deposit(decimal money)
        {
            _balance += money;
            _totalDeposited += money;
        }

        public void interest()
        {
            _totalInterest += _balance * _interest / 12;
            _balance += _balance * _interest / 12;
        }

        public void totalDeposited()
        {
            Console.WriteLine($"Total deposited: {_totalDeposited:C2}");
        }

        public void totalWithDrawn()
        {
            Console.WriteLine($"Total withdrawn: {_totalwithDrawal:C2}");
        }

        public void totalInterest()
        {
            Console.WriteLine($"Total interst earned: {_totalInterest:C2}");
        }

        public decimal balance()
        {
            return _balance;
        }
    }

}

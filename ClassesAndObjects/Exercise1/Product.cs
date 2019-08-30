using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Product
    {
        private string _name;
        private double _priceAtStart;
        private int _amountAtStart;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _priceAtStart = priceAtStart;
            _amountAtStart = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, price {_priceAtStart:0.00}, amount {_amountAtStart}");
        }

        public void changeQuantity(int amount)
        {
            _amountAtStart += amount;
        }

        public void changePrice(double newPrice)
        {
            _priceAtStart = newPrice;
        }
    }
}

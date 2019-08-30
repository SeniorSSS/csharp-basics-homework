using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Car
    {
        private double _currentMileage;
        private double _liters;

        public Car(double startOdo)
        {
            this._currentMileage = startOdo;

        }

        public double CalculateConsumption()
        {
            return _currentMileage / _liters;
        }

        public bool GasHog()
        {
            return 100/CalculateConsumption() > 15 ? true : false;
        }
        public bool EconomyCar()
        {
            return 100/CalculateConsumption() < 5 ? true : false;
        }

        public void FillUp(int mileage, double liters)
        {
            _liters = +liters;
            _currentMileage += mileage;
        }

    }
}

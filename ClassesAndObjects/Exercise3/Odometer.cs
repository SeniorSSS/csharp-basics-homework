using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    public class Odometer
    {
        private int _mileage;
        private int _maxMileage = 9;
        private int _minMileage = 0;
        private FuelGauge _fuelGauge;

        public Odometer(FuelGauge fuelGauge)
        {
            _fuelGauge = fuelGauge;
        }
        public int ReportMileage()
        {
            return _mileage;
        }

        public void Increment()
        {
            if (_fuelGauge.ReportLevel() > 0)
            {
                if (_mileage < _maxMileage)
                {
                    _mileage++;
                }
                else
                {
                    _mileage = 0;
                }

                if (_mileage % 10 == 0)
                {
                    _fuelGauge.DecreaseLevel();
                }
            }
            else
            {
                throw new Exception($"no fuel");
            }
        }

    }
}

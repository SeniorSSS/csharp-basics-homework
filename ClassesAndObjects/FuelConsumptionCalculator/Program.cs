using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            double startKilometers, endKilometers, liters;

 

            Car car = new Car( 1);
            car.FillUp(100, 50);

              Console.WriteLine("l per 100km are " + car.CalculateConsumption());
              Console.WriteLine(car.GasHog());

              car.FillUp(1000, 5);

              Console.WriteLine("l per 100km are " + car.CalculateConsumption());
              Console.WriteLine(car.GasHog());

            Console.ReadKey();
        }
    }
}

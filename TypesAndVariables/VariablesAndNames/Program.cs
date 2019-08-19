using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {

            int cars = 100;
            int seatsinaCar = 4;
            int drivers = 30; 
            int passengers = 90; 
            int carsnotDriven = cars - drivers; // free cars
            int carsDriven = drivers; // cars driven at the moment
            int carpoolCapacity = carsDriven * seatsinaCar;
            double res = passengers / carsDriven;
            double averagePassengersPerCar = Math.Round(res, 2);

            Console.WriteLine("There are {0} cars available.", cars);
            Console.WriteLine("There are only {0} drivers available.", drivers);
            Console.WriteLine("There will be {0} empty cars today.", carsnotDriven);
            Console.WriteLine("We can transport {0} people today.", carpoolCapacity);
            Console.WriteLine("We have {0} to carpool today.", passengers);
            Console.WriteLine("We need to put about {0:F2} in each car.", averagePassengersPerCar);
            Console.ReadKey();
        }
    }
}
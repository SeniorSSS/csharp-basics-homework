﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            var energyDrinkers = CalculateEnergyDrinkers(NumberedSurveyed);
             Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
             Console.WriteLine("Approximately " + (int)energyDrinkers + " bought at least one energy drink");
             Console.WriteLine(" of those " + (int)CalculatePreferCitrus(NumberedSurveyed) + " prefer citrus flavored energy drinks.");

             Console.ReadKey();
        }

        public static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return numberSurveyed * PurchasedEnergyDrinks;
        }

        public static double CalculatePreferCitrus(int numberSurveyed)
        {
            return numberSurveyed * PurchasedEnergyDrinks * PreferCitrusDrinks;
        }
    }
}

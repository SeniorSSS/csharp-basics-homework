using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var fuelGauge = new FuelGauge();
            var odometr = new Odometer(fuelGauge);
            


            for (var i = 0; i < 7; i++)
            {
                fuelGauge.Fill();
            }

            for (var i = 0; i < 101; i++)
            {
                odometr.Increment();
                Console.WriteLine(odometr.ReportMileage());
                Console.WriteLine(fuelGauge.ReportLevel()+"litri");

                Console.ReadKey();
            }

 
            Console.ReadKey();
        }
    }
}

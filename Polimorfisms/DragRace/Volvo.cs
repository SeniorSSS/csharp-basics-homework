using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Volvo : ICar, IModifiedCar
    {
        private int currentSpeed = 0;

        public string Name()
        {
            return "Volvo";
        }
        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void SlowDown()
        {
            currentSpeed -= 10;
        }

        public void SpeedUp()
        {
            currentSpeed += 6;
        }

        public void StartEngine()
        {
            Console.WriteLine("grgrgrgrgrgrg");
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 50;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    class Audi : ICar
    {
        private int currentSpeed = 0;

        public string Name()
        {
            return "Audi";
        }
        public void SpeedUp()
        {
            currentSpeed += 10;
        }

        public void SlowDown()
        {
            currentSpeed += 10;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}

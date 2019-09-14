using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<ISound>
            {
                new Firework(),
                new Radio(),
                new Parrot(),
                new Radio(),
                new Firework(),
                new Parrot()
            };

            list.ForEach(s => s.PlaySound());

            Console.ReadKey();
        }
    }
}

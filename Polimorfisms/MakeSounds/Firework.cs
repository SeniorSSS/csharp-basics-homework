using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    public class Firework : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("whoosh-bang");
        }
    }
}

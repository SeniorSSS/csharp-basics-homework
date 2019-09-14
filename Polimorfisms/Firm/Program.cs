using System;

namespace Firm
{
    class Program
    {
        private static void Main(string[] args)
        {
            //-----------------------------------------------------------------
            // Creates a staff of employees for a firm and pays them.
            //-----------------------------------------------------------------

                var personnel = new Staff();
                personnel.Payday();

            Console.ReadKey();
        }
    }
}

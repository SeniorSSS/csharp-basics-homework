using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 7;
            string output = "";

            switch (i)
            {
                case 1:
                    output = "Pirmdiena";
                    break;
                case 2:
                    output = "Pirmdiena";
                    break;
                default:
                    output = "Nav tadas dienas";
                    break;
            }
            

            Console.WriteLine(output);
        }
    }
}

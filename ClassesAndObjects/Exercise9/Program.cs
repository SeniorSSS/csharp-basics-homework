using System;

namespace Exercise9
{
    class Program
    {
        static void swapPoints(ref Point a,ref Point b)
        {
            var tempPoint = new Point(a);
            a = b;
            b = tempPoint;
        }
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
            swapPoints(ref p1,ref p2);
            Console.WriteLine("-=swap=-");
            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");

            Console.ReadKey();
        }
    }
}

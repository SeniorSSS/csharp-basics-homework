using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product("Logitech mouse", 70.00, 14);
            var iPhone = new Product("iPhone 5s", 999.99, 3);
            var printer = new Product("Epson EB-U05", 440.46, 1);

            mouse.PrintProduct();
            iPhone.PrintProduct();
            printer.PrintProduct();

            Console.WriteLine();

            mouse.changeQuantity(-5);
            iPhone.changePrice(777.77);
            printer.changeQuantity(+3);

            mouse.PrintProduct();
            iPhone.PrintProduct();
            printer.PrintProduct();


            Console.ReadKey();
        }
    }
}

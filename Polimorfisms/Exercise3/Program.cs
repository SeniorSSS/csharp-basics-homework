using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student students = new Student("Juris", "Maskavas", "Rīga", 14, 7.45);
            Employee darbinieks = new Employee("NeJuris", "NeMaskavas", "neRīga", 5, "programētājs");

            students.display();
            darbinieks.display();

            Console.ReadKey();
        }
    }
}

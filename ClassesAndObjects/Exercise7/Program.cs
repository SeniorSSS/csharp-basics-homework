using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Rocky = new Dog("Rocky", "male");
            Dog Lady = new Dog("Lady", "female");
            Dog Sparky = new Dog("Sparky", "male");
            Dog Coco = new Dog("Coco", "female");
            Dog Max = new Dog("Max", "male", Rocky, Lady);
            Dog Mutant = new Dog("Mutant","female",Max,Lady);

            Console.WriteLine(Max.FatherName());
            Console.WriteLine(Sparky.FatherName());
            Console.WriteLine(Max.HasSameMotherAs(Mutant));
            Console.WriteLine(Coco.HasSameMotherAs(Mutant));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySet = new HashSet<string>();

            //TODO: add 5 values to Set.
            mySet.Add("Red");
            mySet.Add("Black");
            mySet.Add("Yellow");
            mySet.Add("Green");
            mySet.Add("White");
            //..

            Console.WriteLine("Should have 5 elements: ");
            Console.WriteLine(string.Join(",", mySet)); //Pay attention on order!

            //TODO: iterate through all elements in set

            foreach (var color in mySet)
            {
                Console.WriteLine(color);
            }

            //for variants
            for (var i = 0; i < mySet.Count; i++)
            {
                Console.WriteLine(mySet.ElementAt(i));
            }


                //TODO: remove all values from set
            mySet.Clear();
            Console.WriteLine("Is mySet empty: ");
            Console.WriteLine(mySet.Count == 0);

            //TODO: check if it is possible to add duplicated values
            mySet.Add("Green");
            mySet.Add("Orange");
            mySet.Add("Green");
            mySet.Add("Purple");

            Console.WriteLine(string.Join(",", mySet));

            Console.ReadKey();
        }
    }
}

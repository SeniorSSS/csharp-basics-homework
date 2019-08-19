using System;

namespace AsciiFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max=15;

            Console.WriteLine("Ievadi pozitivu skaitli ({0}-{1}): ",min+1,max);
            int rowCount = Convert.ToInt32(Console.ReadLine());
            if (rowCount > min&&rowCount<max+1)
            {
                int charCount = 8*(rowCount -1);
                string firstLine = "";
               // firstLine = firstLine.PadLeft(charCount/2,'/');
                //firstLine = firstLine.PadRight(charCount, '\\');
                //Console.WriteLine(firstLine);
                for (var i = 0; i < rowCount; i++)
                {
                    string line = "";
                    line= line.PadLeft(charCount / 2 - i *8/ 2, '/');
                    line=line.PadRight(charCount / 2+i*8/2,'*');
                    line=line.PadRight(charCount, '\\');
                    Console.WriteLine(line);
                }


            }
            else
            {
                Console.WriteLine("skaitlis neatbilst prasibam!");
            }


            Console.ReadKey();
        }
    }
}

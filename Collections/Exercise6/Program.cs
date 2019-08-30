using System;
using System.IO;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        private const string Path = "../lear.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            int i = 0;
            char[] delimiters = new char[] {' ','.',',','!','?',':',';', '\r', '\n' };

            var text = "";

            foreach (var s in readText)
            {
                Console.WriteLine(s);
                i++; // rindu skaititajs
                text += s+ " ";


            }
            /* string[] words = text.Split(delimiters);
             int chars = 0;

             foreach (string word in words)
             {
                 chars += word.Length;
                 Console.WriteLine(word);
             }
             */
            var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
            var words = text.Split().Select(x => x.Trim(punctuation));
            int wordCount = 0;
            int charCount = 0;

            foreach (var word in words)
            {
              if (word != "")
              {
                //  Console.WriteLine(word);
                  wordCount++;
                //  char[] burti = word.ToCharArray();
                foreach (var burts in word)
                {
                    charCount += Char.IsLetterOrDigit(burts) ? 1 : 0;
                }
                  

              } 
            }


            Console.WriteLine("================================");
            Console.WriteLine($"Rindas = {i}");
            Console.WriteLine($"Vardi = {wordCount}");
            Console.WriteLine($"Burti = {charCount}");

            Console.ReadKey();
        }
    }
}

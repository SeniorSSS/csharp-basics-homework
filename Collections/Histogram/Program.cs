using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace Histogram
{

    class Program
    {


        private const string Path = "../../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);
            string text = "";
            SortedList<int, int> scores = new SortedList<int, int>()
                                            {
                                                {0,0 },
                                                {1,0 },
                                                {2,0 },
                                                {3,0 },
                                                {4,0 },
                                                {5,0 },
                                                {6,0 },
                                                {7,0 },
                                                {8,0 },
                                                {9,0 },
                                                {10,0 }
                                            };
         /*   foreach (var s in readText)
            {
                //Console.WriteLine(s);
                text += s + " ";

            }
*/
            var inputArr = text.Split(' ');
            foreach (var elem in inputArr)
            {
                var element = elem.Trim(' ');
                if (element != "")
                {
                    var number = Int32.Parse(element);
                    int dictKey = 0;
                    if (number == 100)
                    {
                        dictKey = 10;
                    }
                    else
                    {
                        dictKey = (int) number / 10;
                    }

                    scores[dictKey] += 1;


                }
            }

            for (var i = 0; i < scores.Count; i++)
            {
                var scoreRange = "";
                if (scores.Keys[i] == 10)
                {
                    scoreRange = "100:";
                }
                else
                {
                    scoreRange = (scores.Keys[i] * 10).ToString() + "-" + (scores.Keys[i] * 10 + 9).ToString() + ":";
                }

                string results = new String('*', scores.Values[i]);
                Console.WriteLine(scoreRange.PadLeft(8,' ')+" "+results);
            }

            Console.ReadKey();
        }


    }
}

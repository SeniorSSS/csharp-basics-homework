using System;


namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"astronauts","smadzenes","dators","kiosks","miegs","galds","miskaste","pienene","laura","piens","orgasms" };
            Random rnd = new Random();
            var randomWordNumber = rnd.Next(0, words.Length);
            string randomWord = words[randomWordNumber];
            char[] guess = new char[randomWord.Length];
            for (var i = 0; i < randomWord.Length; i++)
            {
                guess[i] = '-';
            }
            string usedLetters = "";
            string foundLetters = "";
            int miss = 0;
            int max = 8;
            char lastLetter = ' ';
            bool found = false;
            int foundCount = 0;

            do
            {
                Display(randomWord, usedLetters, lastLetter, guess);

                char input = Console.ReadKey().KeyChar;

                if (randomWord.ToLower().Contains(input)&& !foundLetters.ToLower().Contains(input))
                {
                    lastLetter = input;
                    int checkGuess = 0;
                    foundLetters += input.ToString();
                    for (var i = 0; i < randomWord.Length; i++)
                    {
                    


                        if (randomWord[i] == input)
                        {
                            guess[i] = input;
                            foundCount++;
                        }

                    }
 
                }
                else
                {
                    if (!usedLetters.ToLower().Contains(input)&& !foundLetters.ToLower().Contains(input))
                    {
                        usedLetters += input.ToString();
                        lastLetter = input;
                        miss++;
                    }
                }

                if (foundCount == randomWord.Length)
                {
                    found = true;
                }

            } while (miss!=max&&!found);

            if (found)
            {
                Display(randomWord, usedLetters, lastLetter, guess);
                Console.WriteLine("Apsveicu Tu uzmineji vardu {0} ar {1} kludam!",randomWord, miss);
            }
            else
            {
                Console.WriteLine("Piedod, bet Tu nespeji uzminet so vardu!");
            }

            Console.ReadKey();
        }

        private static void Display(string word, string used, char last, char[] arr)
        {
            Console.Clear();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.Write("Vards:");
            for (var k = 0; k < word.Length; k++)
            {
                Console.Write(arr[k] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Nepareizie: {0}", used);
            Console.WriteLine("Pedejais minejums: {0}", last);
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
           
        }

    }
}

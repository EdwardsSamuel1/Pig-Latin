using System;
using static System.Char;

namespace PigLatin
{
    internal class Program
    {

        // Switch for the vowels
        static bool isVowel(char c)
        {
            switch (c)
            {
                // Every vowel
                case 'a': case 'A': case 'e': case 'E': case 'i': case 'I': case 'o': case 'O': case 'u': case 'U':
                    return true;
                default:
                    return false;
            }
        }

        // We find the number of consonants before the vowel to move to the end
        static int ConsonantNum(string s)
        {
            int consonant = 0;
            foreach(char c in s)
            {
                // Increment the consonant count and quit at the first vowel
                if (!isVowel(c))
                        consonant++;
                else break;
            }
            return consonant;
        }

        // Make the pig string
        static string ToPig(string input)
        {
            if (isVowel(input[0]))
            {
                return  input + "yay";
            }
            else
            {
                int num = ConsonantNum(input);
                /* Substring returns the string after n chars, and gives the rest. 
                * It can also return n after a certain index.
                */
                if (IsUpper(input, 0))
                {
                    return input.Substring(num, 1).ToUpper() + input.Substring(num + 1) + input.Substring(0, num).ToLower() + "ay";
                }
                return input.Substring(num) + input.Substring(0, num) + "ay";
            }
        }

        static void Main()
        {
            string input;
            string[] split;

            Console.Write("Text to translate: ");
            input = Console.ReadLine();

            // This allows multiple words to be translated
            split = input.Split(" ");

            // Translate one word at a time
            foreach (string s in split)
            {
                Console.Write($"{ToPig(s)} ");
            }
            Console.Write("\n");

        }
    }
}

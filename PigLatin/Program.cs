using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization.Metadata;

namespace PigLatin
{
    internal class Program
    {

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
            int n = 0;
            for (int i = 0; i < s.Length;)
            {
                if(!isVowel(s[i]))
                {
                    n++;
                }
        }

            // Make the pig string
        static string ToPig(string input)
        {
            if (isVowel(input[0]))
            {
                return  input + "ay";
            }
            else
            {
                int num = ConsonantNum(input);
                return input.Substring(num) + input.Substring(0, num) + "ay" + $"{num}";
            }
        }

        static void Main(string[] args)
        {
            string input;

            Console.Write("Text to translate: ");
            input = Console.ReadLine();
            string[] split = input.Split(" ");

            foreach (string s in split)
            {
                Console.Write(ToPig(s) + " ");
            }
            Console.Write("\n");
            

        }
    }
}

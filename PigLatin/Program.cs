using System.ComponentModel;
using System.Text.Json.Serialization.Metadata;

namespace PigLatin
{
    internal class Program
    {
        static bool isVowel(char c)
        {
            switch (c)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    return true;
                default:
                    return false;
            }
        }
        /*static string ToPig(string input)
        {
        }*/
        static void Main(string[] args)
        {
            string input;
            string translation;

            Console.Write("Text to translate: ");
            input = Console.ReadLine();

            string[] inArr = input.Split(' ');
            Console.WriteLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_StringCapitals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "HeLlO WoRlD";
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToLower(); 
                if (word.Length > 1)
                {
                    word = word.Substring(0, 1) + char.ToUpper(word[1]) + word.Substring(2);
                }
                words[i] = word;
            }
            string result = string.Join(" ", words);
            Console.WriteLine(result);
        }
    }
    
}

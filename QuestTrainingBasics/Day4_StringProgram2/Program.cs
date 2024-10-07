using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_StringProgram2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            string[] wordsFound = new string[words.Length];
            int wordsCheckedCount = 0;
            foreach (var word in words)
            {
                if(wordsFound.Contains(word))
                {
                    continue;
                }

                int count = 0;
                foreach (var item in words)
                {
                    if (word == item)
                    {
                        count++;
                    }
                }

                wordsFound[wordsCheckedCount] = word;
                wordsCheckedCount++;
                Console.WriteLine($"{word}: {count}");
            }
        }
    }
}

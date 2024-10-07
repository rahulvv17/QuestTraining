using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if it's a palindrome:");
            string input = Console.ReadLine();
            string formattedInput = input.Replace(" ", "").ToLower();
            string reversedInput = new string(formattedInput.Reverse().ToArray());
            if (formattedInput == reversedInput)
            {
                Console.WriteLine($"'{input}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"'{input}' is not a palindrome.");
            }
        }
    }
}

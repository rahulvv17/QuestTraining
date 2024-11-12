using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        static void Main()
        {
            string original = "Hello, World";
            string reversed = ReverseString(original);

            Console.WriteLine("Original string: " + original);
            Console.WriteLine("Reversed string: " + reversed);
        }

        static string ReverseString(string input)
        {
            char[] charArray = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                charArray[i] = input[input.Length - 1 - i];
            }
            return new string(charArray);
        }
    }
}

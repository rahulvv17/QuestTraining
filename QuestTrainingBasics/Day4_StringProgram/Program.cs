using System;

namespace Day4_StringProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sent = "This is a really long text";
            Console.WriteLine("Enter the text to replace:");
            string oldText = Console.ReadLine();
            Console.WriteLine("Enter the replacement text:");
            string newText = Console.ReadLine();
            string newSent = sent.Replace(oldText, newText);
            Console.WriteLine("Modified Text: " + newSent);
        }
    }
}

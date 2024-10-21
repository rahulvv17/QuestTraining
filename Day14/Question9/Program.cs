using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printMessage = (message) => Console.WriteLine(message);
            printMessage("Welcome to the program!");
        }
    }
}

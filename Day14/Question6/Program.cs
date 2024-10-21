using System;

namespace Question6
{
    delegate void PrintMessage(string message);

    class Program
    {
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            PrintMessage pm = DisplayMessage;
            pm("Hello, this is a message!");
        }
    }
}

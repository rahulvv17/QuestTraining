using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> stringLength = (str) => str.Length;
            Console.WriteLine($"Length: {stringLength("Hello World")}");
        }
    }
}

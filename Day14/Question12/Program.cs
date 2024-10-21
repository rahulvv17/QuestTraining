using System;

namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startsWithA = (str) => str.StartsWith("A");
            Console.WriteLine($"Does 'Apple' start with A? {startsWithA("Apple")}");
        }
    }
}

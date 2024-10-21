using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = (x) => x % 2 == 0;
            Console.WriteLine($"Is 4 even? {isEven(4)}");
        }
    }
}

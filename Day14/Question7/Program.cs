using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> sum = (x, y) => x + y;
            Console.WriteLine($"Sum: {sum(5, 10)}");
        }
    }
}

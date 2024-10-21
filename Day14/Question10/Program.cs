using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> sumAction = (x, y) => Console.WriteLine($"Sum: {x + y}");
            sumAction(5, 7);
        }
    }
}

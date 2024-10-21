using System;

namespace Question4
{
    interface ICalculator
    {
        void Add(int a, int b);
        void Subtract(int a, int b);
    }

    class SimpleCalculator : ICalculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Difference: {a - b}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ICalculator calculator = new SimpleCalculator();
            calculator.Add(5, 3);
            calculator.Subtract(10, 7);
        }
    }
}

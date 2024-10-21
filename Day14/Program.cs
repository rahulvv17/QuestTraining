using System;

namespace Question5
{
    delegate int Operation(int x, int y);

    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Operation opAdd = Add;
            Operation opMul = Multiply;

            Console.WriteLine($"Add: {opAdd(5, 3)}");
            Console.WriteLine($"Multiply: {opMul(5, 3)}");
        }
    }
}

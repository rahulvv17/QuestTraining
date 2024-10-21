using System;

abstract class CalculatorBase
{
    public void Add(int a, int b) => Console.WriteLine(a + b);
    public void Subtract(int a, int b) => Console.WriteLine(a - b);
    public void Multiply(int a, int b) => Console.WriteLine(a * b);
    public virtual void Divide(int a, int b) => Console.WriteLine(a / b);
    public abstract void Power(int a, int b);
}

class Calculator : CalculatorBase
{
    public override void Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero is not possible");
            return;
        }
        base.Divide(a, b);
    }

    public override void Power(int a, int b)
    {
        Console.WriteLine(Math.Pow(a, b));
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        calc.Add(5, 3);         // Outputs 8
        calc.Subtract(10, 4);   // Outputs 6
        calc.Multiply(7, 6);    // Outputs 42
        calc.Divide(12, 4);     // Outputs 3
        calc.Divide(12, 0);     // Outputs "Division by zero is not possible"
        calc.Power(2, 3);       // Outputs 8
    }
}

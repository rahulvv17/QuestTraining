using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day4_1.Functions
{
    internal class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static void SingleLineAdd(int a, int b)=>Console.WriteLine(a + b);
        static void subtract(int a, int b) => Console.WriteLine(a - b);
        static void multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        static void divide(int a, int b)
        {
            Console.WriteLine(a/b);
        }
        static void Main(string[] args)
        {
            Greet("John");
            Console.WriteLine("Enter number one");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number second");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator");
            string ope= Console.ReadLine();

            if(ope=="+")
            {
                SingleLineAdd(a, b);
            }
            else if(ope=="-")
            {
                subtract(a, b);
            }
            else if (ope=="*")
            {
                multiply(a, b);
            }
            else if (ope == "/")
            {
                divide(a, b);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

        }
    }
}

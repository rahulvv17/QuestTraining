using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static int Clac(bool doAddition, int a, int b)
        {
            return doAddition ? a + b : a - b;
        }

        static void Main(string[] args)
        {
            var result = Clac(true, 2, 3);
            Console.WriteLine(result); 
        }
    }
}

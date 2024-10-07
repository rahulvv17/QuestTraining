using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Namespaces.Utilities
{
    internal class MathUtilities
    {
        public static void add(int a, int b) => Console.WriteLine(a + b);

        public static void sub(int a, int b) => Console.WriteLine(a-b);

        public static void mul(int a, int b) => Console.WriteLine(Math.Pow(a, b));

        public static void div(int a, int b) => Console.WriteLine(a/b);

    }
}

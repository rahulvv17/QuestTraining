using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // From an array/list, skip the first 3 elements, take the next five elements
            // and find the sum of even numbers from the taken 5 elements.

            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sum = data.Skip(3).Take(5).Where(x => x % 2 == 0).Sum();
            Console.WriteLine(sum);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_RemoveEvenFromList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine("List after removing even numbers:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}

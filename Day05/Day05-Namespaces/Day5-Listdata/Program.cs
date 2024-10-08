using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Listdata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Lst = new List<int>();

            // Adds a single element.
            Lst.Add(10);

            // Adding multiple values.
            var valuesToAdd = new int[] { 20, 30, 40, 50, 50 };
            Lst.AddRange(valuesToAdd);

            // Updating the element.
            Lst[0] = 100;

            // Deleting the element.
            // To remove the first occurrence of 50.
            Lst.Remove(50);

            // Remove from a specific index.
            Lst.RemoveAt(1);

            // Iterating through the list using for loop.
            for (int i = 0; i < Lst.Count; i++)
            {
                Console.Write(Lst[i] + ", ");
            }
            Console.WriteLine();

            // Iterating using foreach loop.
            foreach (var item in Lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}

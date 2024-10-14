using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_ResizeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] originalArray = { 1, 2, 3 };

            // Convert to a list
            List<int> list = new List<int>(originalArray);

            // Add elements to the list
            list.Add(4);
            list.Add(5);

            // Convert back to an array
            int[] newArray = list.ToArray();
            
        }
    }
}

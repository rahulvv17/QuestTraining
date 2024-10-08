using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_ListofList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<List<int>>();

            for (int i = 0; i < 2; i++)
            {
                var marks = new List<int>(); 

               
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"Enter mark {j}: ");
                    int mark = int.Parse(Console.ReadLine());
                    marks.Add(mark); 
                }
                data.Add(marks);
            }
            Console.WriteLine("\nMarks entered:");
            for (int i = 0; i < data.Count; i++)
            {
                Console.Write($"Student {i + 1}: ");
                foreach (var mark in data[i])
                {
                    Console.Write(mark + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(); 
        }
    }
}

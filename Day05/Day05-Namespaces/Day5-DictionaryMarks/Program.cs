using System;
using System.Collections.Generic;

namespace Day5_DictionaryMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<string, List<int>>();

            while (true)
            {
                Console.WriteLine("Enter an Id or q to exit:");
                var option = Console.ReadLine();

                if (option == "q")
                {
                    break;
                }

                // Check if the entered ID already exists in the dictionary
                if (d.ContainsKey(option))
                {
                    Console.WriteLine("ID already exists. Do you want to overwrite it? (yes/no)");
                    var overwrite = Console.ReadLine();

                    if (overwrite.ToLower() != "yes")
                    {
                        continue; // Skip to the next iteration if the user doesn't want to overwrite
                    }
                }

                // Proceed to add or overwrite marks
                var marks = new List<int>();
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Enter mark {i}: ");
                    var mark = int.Parse(Console.ReadLine());
                    marks.Add(mark);
                }

                // Add new entry or overwrite the existing one
                d[option] = marks;
            }

            // Print the stored data
            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }
        }
    }
}

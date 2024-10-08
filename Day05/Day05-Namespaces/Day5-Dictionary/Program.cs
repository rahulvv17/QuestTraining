using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<string, string>();
            //Adding elements
            d.Add("First Name", "John");
            d.Add("Last Name", "Wick");

            Console.WriteLine(d["First Name"]);

            //updating an value
            d["First Name"] = "Jane";
            Console.WriteLine(d["First Name"]);

            //Remove a value
            d.Remove("Last Name");

            //Check if a key exits
            if (d.ContainsKey("Age"))
            {
                Console.WriteLine("Age key exits");
            }
            else
            {
                Console.WriteLine("Age does not exits");
            }

            //looping a Dictionary

            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }


        }
    }
}

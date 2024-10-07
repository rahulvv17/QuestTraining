using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daay4_StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "Rahul", "Vyshak", "Vishal" };
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].Trim();
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]} is {i} year(s) old");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Person
    {
        static void Main(string[] args)
        {
            var data = new List<Person>()
        {
            new Person { Name = "Person 1", Country = "US", Age = 20 },
            new Person { Name = "Person 2", Country = "US", Age = 30 },
            new Person { Name = "Person 3", Country = "US", Age = 40 },
            new Person { Name = "Person 4", Country = "IN", Age = 50 }
        };

            // Filter persons from the US
            var res = data.Where(p => p.Country == "US");

            // Print the name of each person from the US
            foreach (var person in res)
            {
                Console.WriteLine(person.Name);
            }
        }
    }

    
}

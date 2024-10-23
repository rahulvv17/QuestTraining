using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Person<TEmailType>
    {
        public string Name { get; set; }
        public TEmailType Emails { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a person with a string array of emails
            var p1 = new Person<string[]> { Name = "John" };
            // Creating a person with a list of emails
            var p2 = new Person<List<string>> { Name = "Jane" };
            // Creating a person with a single email
            var p3 = new Person<string> { Name = "Jim" };

            // Assigning emails to each person
            p1.Emails = new string[] { "a@a.com", "a@b.com" };
            p2.Emails = new List<string> { "1@mail.com", "2@mail.com" };
            p3.Emails = "3@mail.com";

            // Output for verification
            Console.WriteLine($"{p1.Name}'s Emails: {string.Join(", ", p1.Emails)}");
            Console.WriteLine($"{p2.Name}'s Emails: {string.Join(", ", p2.Emails)}");
            Console.WriteLine($"{p3.Name}'s Email: {p3.Emails}");
        }
    }
}

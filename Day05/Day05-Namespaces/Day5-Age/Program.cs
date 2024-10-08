using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your birthdate (yyyy-mm-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }
            Console.WriteLine($"You are {age} years old.");
        }
    }
}

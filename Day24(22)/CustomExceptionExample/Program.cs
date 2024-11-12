using System;

namespace CustomExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());
                Person person = new Person(name, age);
                Console.WriteLine($"Person created successfully! Name: {person.Name}, Age: {person.Age}");
            }
            catch (AgeOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}

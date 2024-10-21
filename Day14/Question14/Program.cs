using System;

namespace Question14
{
    abstract class Person
    {
        public abstract void Work();
    }

    class Doctor : Person
    {
        public override void Work()
        {
            Console.WriteLine("Doctor is treating patients.");
        }
    }

    class Engineer : Person
    {
        public override void Work()
        {
            Console.WriteLine("Engineer is designing buildings.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person doctor = new Doctor();
            Person engineer = new Engineer();

            doctor.Work();
            engineer.Work();
        }
    }
}

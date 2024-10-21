using System;

namespace Question16
{
    class Employee
    {
        public virtual void CalculateBonus()
        {
            Console.WriteLine("Employee bonus: 10%");
        }
    }

    class Manager : Employee
    {
        public override void CalculateBonus()
        {
            Console.WriteLine("Manager bonus: 20%");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee mgr = new Manager();

            emp.CalculateBonus();
            mgr.CalculateBonus();
        }
    }
}

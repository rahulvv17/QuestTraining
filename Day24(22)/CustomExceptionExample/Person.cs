using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionExample
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            SetAge(age);
        }
        public void SetAge(int age)
        {
            if (age < 1 || age > 120)
            {
                throw new AgeOutOfRangeException("Age must be between 1 and 120.");
            }
            Age = age;
        }
    }
}

using System;

namespace Question15
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some sound...");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.MakeSound();
        }
    }
}

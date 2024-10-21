using System;

namespace Question13
{
    abstract class Appliance
    {
        public abstract void TurnOn();
    }

    class Fan : Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Fan is now on.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Appliance myFan = new Fan();
            myFan.TurnOn();
        }
    }
}

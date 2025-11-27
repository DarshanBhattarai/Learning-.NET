using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal class Task5
    {
        // Abstract base class
        public abstract class Vehicle
        {
            public abstract void StartEngine();
            public abstract void StopEngine();

            // Concrete method
            public void Display()
            {
                Console.WriteLine("This is a vehicle");
            }
        }

        // Derived class Car
        public class Car : Vehicle
        {
            public override void StartEngine()
            {
                Console.WriteLine("Car engine started");
            }

            public override void StopEngine()
            {
                Console.WriteLine("Car engine stopped");
            }
        }

        // Derived class Bike
        public class Bike : Vehicle
        {
            public override void StartEngine()
            {
                Console.WriteLine("Bike engine started");
            }

            public override void StopEngine()
            {
                Console.WriteLine("Bike engine stopped");
            }
        }
    }
}

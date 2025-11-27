using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal class Task2
    {
        public class Vehicle
        {
            public string Brand { get; set; }
            public int Speed { get; set; }


            public void start()
            {
                Console.WriteLine("Engine started.");
            }
            public void stop()
            {
                Console.WriteLine("Engine stopped.");
            }
            public virtual  void DisplayInfo()
            {
                Console.WriteLine($"Brand: {Brand}, Speed:{Speed}");
            }

            public virtual void run()
            {
                start();
                DisplayInfo();
                stop();
            }

        }
            public class Car: Vehicle
        {
            public int Seats { get; set; }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Seats: {Seats}");
            }
            public override void run()
            {
                Console.WriteLine("Car is running.");
                base.run();
            }

          
        }
        public class Motorcycle : Vehicle
        {
            public bool HasCarrier { get; set; }
            public override void DisplayInfo()
            {
                Console.WriteLine($"Has Sidecar: {HasCarrier}");
            }
            public override void run()
            {
                Console.WriteLine("Motorcycle is running.");
                base.run();
            }
        }
    }
}

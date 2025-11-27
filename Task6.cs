using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal class Task6
    {
        // Abstract base class
        public abstract class ElectronicDevice
        {
            // Private fields
            private string brand;
            private double price;

            // Encapsulated public properties
            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }

            public double Price
            {
                get { return price; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Price cannot be negative");
                    price = value;
                }
            }

            // Constructor
            public ElectronicDevice(string brand, double price)
            {
                Brand = brand;
                Price = price;
            }

            // Abstract method
            public abstract void ShowInfo();
        }

        // Derived class Laptop
        public class Laptop : ElectronicDevice
        {
            public Laptop(string brand, double price) : base(brand, price) { }

            public void TurnOnBattery()
            {
                Console.WriteLine($"{Brand} laptop battery is turned on.");
            }

            public override void ShowInfo()
            {
                Console.WriteLine($"Laptop Brand: {Brand}, Price: ${Price}");
            }
        }

        // Derived class Smartphone
        public class Smartphone : ElectronicDevice
        {
            public Smartphone(string brand, double price) : base(brand, price) { }

            public void EnableCamera()
            {
                Console.WriteLine($"{Brand} smartphone camera is enabled.");
            }

            public override void ShowInfo()
            {
                Console.WriteLine($"Smartphone Brand: {Brand}, Price: ${Price}");
            }
        }

        // Electronics Store
        public class ElectronicsStore
        {
            private List<ElectronicDevice> devices = new List<ElectronicDevice>();

            // Add device
            public void AddDevice(ElectronicDevice device)
            {
                devices.Add(device);
            }

            // Remove device
            public void RemoveDevice(ElectronicDevice device)
            {
                devices.Remove(device);
            }

            // Show all device details
            public void ShowAllDeviceDetails()
            {
                foreach (var device in devices)
                {
                    device.ShowInfo();

                    // Downcast to call child-specific methods
                    if (device is Laptop laptop)
                    {
                        laptop.TurnOnBattery();
                    }
                    else if (device is Smartphone phone)
                    {
                        phone.EnableCamera();
                    }

                    Console.WriteLine(); // For spacing
                }
            }
        }   
    }
}

using consolePrint1;
using System;

namespace ConsoleApp
{
    internal class UserInfo
    {
        public static void Main(string[] args)
        {
            // Directly assign the info (no user input)
            string name = "Pratik Dangal";
            string address = "Bhojpur";
            string contact = "9807985184";
            string college = "IIC";

            Console.WriteLine("--- Your Details ---");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Contact Number: {contact}");
            Console.WriteLine($"College: {college}");

            Console.WriteLine("\nThank you for providing your information!");

            // Optional: Call Motivation.ShowMessage() if defined
            Motivation.ShowMessage();
        }
    }
}
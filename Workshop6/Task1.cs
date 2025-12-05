using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Task1
    {
        public class Rectangle
        {
            public double Length { get; set; }
            public double Breadth { get; set; }

            // Expression-bodied members
            public double Area() => Length * Breadth;
            public double Perimeter() => 2 * (Length + Breadth);
        }

        // Run method for Task 1
        public static void Run()
        {
            var rect = new Rectangle
            {
                Length = 10,
                Breadth = 5
            };

            
            Console.WriteLine($"Area: {rect.Area()}");
            Console.WriteLine($"Perimeter: {rect.Perimeter()}");
        }
    }
}

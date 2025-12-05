using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Task6
    {
        // Booking class for tour details
        public class Booking
        {
            public string CustomerName { get; set; }
            public string Destination { get; set; }
            public double Price { get; set; }
            public int DurationInDay { get; set; }
            public bool IsInternational { get; set; }
        }

        public static void Run()
        {
            Console.WriteLine("=== Task 6: Travel Company Tour Analysis ===");

            // Sample booking list
            List<Booking> bookings = new List<Booking>
        {
            new Booking { CustomerName = "Aayush", Destination = "Pokhara", Price = 8000, DurationInDay = 3, IsInternational = false },
            new Booking { CustomerName = "Sita", Destination = "Dubai", Price = 45000, DurationInDay = 6, IsInternational = true },
            new Booking { CustomerName = "Ramesh", Destination = "Chitwan", Price = 12000, DurationInDay = 5, IsInternational = false },
            new Booking { CustomerName = "Laxmi", Destination = "Bangkok", Price = 38000, DurationInDay = 4, IsInternational = true },
            new Booking { CustomerName = "Hari", Destination = "Ilam", Price = 5000, DurationInDay = 2, IsInternational = false }
        };

            var expensiveTours = bookings.Where(b => b.Price > 10000);

            Console.WriteLine("\nTours Above Rs. 10,000:");
            foreach (var b in expensiveTours)
            {
                Console.WriteLine($"{b.CustomerName} → {b.Destination} → Rs. {b.Price}");
            }

           
            // 2️⃣ Tours with duration more than 4 days
            var longTours = bookings.Where(b => b.DurationInDay > 4);

            Console.WriteLine("\nTours With Duration > 4 Days:");
            foreach (var b in longTours)
            {
                Console.WriteLine($"{b.CustomerName} → {b.Destination} ({b.DurationInDay} days)");
            }
        }
    }
}

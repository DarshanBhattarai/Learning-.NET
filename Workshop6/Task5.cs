using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Task5
    {
        // ------------------ Classes ------------------
        public class CashierSales
        {
            public string CashierName { get; set; }
            public double Sales { get; set; }
        }

        public class Applicant
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class Music
        {
            public string Title { get; set; }
            public int DurationInSeconds { get; set; } // duration in seconds
        }


        // ------------------ RUN METHOD ------------------
        public static void Run()
        {
            // 1️⃣ Aggregation Operators
            Console.WriteLine("=== Aggregation Operators ===");

            List<CashierSales> salesList = new List<CashierSales>
        {
            new CashierSales { CashierName = "Ram", Sales = 5000 },
            new CashierSales { CashierName = "Sita", Sales = 7000 },
            new CashierSales { CashierName = "Hari", Sales = 3500 },
            new CashierSales { CashierName = "Gita", Sales = 9000 }
        };

            int totalCashiers = salesList.Count();
            double totalSales = salesList.Sum(s => s.Sales);
            double highestSales = salesList.Max(s => s.Sales);
            double lowestSales = salesList.Min(s => s.Sales);
            double avgSales = salesList.Average(s => s.Sales);

            Console.WriteLine($"Total Cashiers: {totalCashiers}");
            Console.WriteLine($"Total Sales: {totalSales}");
            Console.WriteLine($"Highest Sales: {highestSales}");
            Console.WriteLine($"Lowest Sales: {lowestSales}");
            Console.WriteLine($"Average Sales: {avgSales}");


            // 2️⃣ Quantifier Operators (Any/All)
            Console.WriteLine("\n=== Quantifier Operators ===");

            List<Applicant> applicants = new List<Applicant>
        {
            new Applicant { Name = "Aayush", Age = 19 },
            new Applicant { Name = "Bikash", Age = 22 },
            new Applicant { Name = "Suresh", Age = 17 },
            new Applicant { Name = "Mina", Age = 20 }
        };

            bool anyUnder18 = applicants.Any(a => a.Age < 18);
            bool allAbove16 = applicants.All(a => a.Age > 16);

            Console.WriteLine($"Any applicant under 18: {anyUnder18}");
            Console.WriteLine($"All applicants above 16: {allAbove16}");


            // 3️⃣ Element Operators (First, Last, FirstOrDefault)
            Console.WriteLine("\n=== Element Operators ===");

            List<Music> songs = new List<Music>
        {
            new Music { Title = "Song A", DurationInSeconds = 180 },
            new Music { Title = "Song B", DurationInSeconds = 250 },
            new Music { Title = "Song C", DurationInSeconds = 300 },
            new Music { Title = "Song D", DurationInSeconds = 130 }
        };

            var firstSong = songs.First();
            var lastSong = songs.Last();
            var firstAbove4Min = songs.First(s => s.DurationInSeconds > 240); 
            var safeLongSong = songs.FirstOrDefault(s => s.DurationInSeconds > 600); 

            Console.WriteLine($"First Song: {firstSong.Title}");
            Console.WriteLine($"Last Song: {lastSong.Title}");
            Console.WriteLine($"First Song Above 4 Min: {firstAbove4Min.Title}");
            Console.WriteLine($"First Song Above 10 Min (safe): {(safeLongSong != null ? safeLongSong.Title : "No song found")}");

        }
    }
}

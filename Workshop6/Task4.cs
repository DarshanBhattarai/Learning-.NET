using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Task4
    {
        // Book class
        public class Book
        {
            public string Title { get; set; }
            public double Price { get; set; }
        }

        // Student class
        public class Student
        {
            public string Name { get; set; }
        }

        public static void Run()
        {
            Console.WriteLine("=== Selecting / Projection ===");

            // List of integers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Square each number using LINQ Select()
            var squaredNumbers = numbers.Select(n => n * n);

            Console.WriteLine("Squared Numbers:");
            foreach (var sq in squaredNumbers)
                Console.WriteLine(sq);


            // ------------------ Filtering Books ------------------
            Console.WriteLine("\n=== Filtering Books (Price > 1000) ===");

            List<Book> books = new List<Book>
        {
            new Book { Title = "C# Basics", Price = 800 },
            new Book { Title = "Advanced C#", Price = 1500 },
            new Book { Title = "Database Systems", Price = 1200 },
            new Book { Title = "HTML & CSS", Price = 600 }
        };

            var premiumBooks = books.Where(b => b.Price > 1000);

            Console.WriteLine("Premium Books:");
            foreach (var book in premiumBooks)
                Console.WriteLine($"{book.Title} - Rs. {book.Price}");


            // ------------------ Sorting Students ------------------
            Console.WriteLine("\n=== Sorting Students Alphabetically ===");

            List<Student> students = new List<Student>
        {
            new Student { Name = "Ram" },
            new Student { Name = "Aayush" },
            new Student { Name = "Bikash" },
            new Student { Name = "Kamal" },
            new Student { Name = "Sita" },
            new Student { Name = "John" },
            new Student { Name = "Laxmi" },
            new Student { Name = "Zara" },
            new Student { Name = "Pratik" },
            new Student { Name = "Deepa" }
        };

            var sortedStudents = students.OrderBy(s => s.Name);

            Console.WriteLine("Sorted Student Names:");
            foreach (var student in sortedStudents)
                Console.WriteLine(student.Name);
        }
    }
}

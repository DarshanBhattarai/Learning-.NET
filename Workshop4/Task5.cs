using System;

namespace Workshop4
{
    internal class Task5
    {
        public enum DayType
        {
            Weekday,
            Weekend
        }

        public record Book(string title, string author, double price);

        public void Run()
        {
            // DayType Task 
            Console.Write("Enter a day (Example: Sunday): ");
            string day = Console.ReadLine().Trim().ToLower();

            DayType dayType;

            if (day == "friday" || day == "saturday")
                dayType = DayType.Weekend;
            else
                dayType = DayType.Weekday;

            Console.WriteLine($"It is: {dayType}");


            // Book Record Task
            Book book1 = new Book("The Alchemist", "Paulo Coelho", 499.99);

            Book book2 = book1 with
            {
                title = "Rich Dad Poor Dad",
                price = 299.50
            };

            Console.WriteLine("\nFirst Book Details:");
            Console.WriteLine($"Title: {book1.title}, Author: {book1.author}, Price: {book1.price}");

            var (title, author, price) = book2;

            Console.WriteLine("\nSecond Book (Deconstructed):");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }
    }
}

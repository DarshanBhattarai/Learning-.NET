using System;

namespace Week2Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WEEK 2 WORKSHOP\n");

            // Task 1: Greeting Message
            Task1.Run();

            // Task 2: Circle Calculations
            Task2.Run();

            // Task 3: Data Types and Type Conversion
            Task3.Run();

            // Task 4: Array and Array Methods
            Task4.Run();

            // Task 5: DateTime and TimeSpan
            Task5.Run();

            // Task 6: Generic collections and foreach loop
            Task6.Run();

            Console.WriteLine("\nEnd of Workshop");
        }
    }

    // Task 1: Greeting Message
    public class Task1
    {
        public static void Run()
        {
            string userName = "Darshan Bhattarai";
            int luckyNumber = 7;

            Console.WriteLine("Task 1: Greeting Message");
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.\n");
        }
    }

    // Task 2: Circle Calculations
    public class Task2
    {
        public static void Run()
        {
            const double PI = 3.14;

            Console.WriteLine("Task 2: Circle Calculations");
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = PI * radius * radius;
            double perimeter = 2 * PI * radius;

            Console.WriteLine($"\nFor a circle with radius {radius}:");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");

            Circle circle = new Circle();
            Console.WriteLine("\nUsing Circle class methods:");
            Console.WriteLine($"Area (radius = 3): {circle.CalculateArea(3)}");
            Console.WriteLine($"Perimeter (radius = 5): {circle.CalculatePerimeter(5)}\n");
        }
    }

    // Circle class
    public class Circle
    {
        public const double PI = 3.14;

        public double CalculateArea(double radius)
        {
            return PI * radius * radius;
        }

        public double CalculatePerimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }

    // Task 3: Data Types and Type Conversion
    public class Task3
    {
        public static void Run()
        {
            Console.WriteLine("Task 3: Data Types and Type Conversion");

            byte byteValue = 10;
            short shortValue = 200;
            int intValue = 1000;
            long longValue = 50000L;
            float floatValue = 3.14F;
            double doubleValue = 99.99;
            decimal decimalValue = 123.456M;
            char charValue = 'A';
            bool boolValue = true;

            string intToString = intValue.ToString();
            double stringToDouble = Convert.ToDouble("3.14");

            Console.WriteLine($"\nbyte: {byteValue}");
            Console.WriteLine($"short: {shortValue}");
            Console.WriteLine($"int: {intValue}");
            Console.WriteLine($"long: {longValue}");
            Console.WriteLine($"float: {floatValue}");
            Console.WriteLine($"double: {doubleValue}");
            Console.WriteLine($"decimal: {decimalValue}");
            Console.WriteLine($"char: {charValue}");
            Console.WriteLine($"bool: {boolValue}");
            Console.WriteLine($"\nConverted int (42) to string: \"{intToString}\"");
            Console.WriteLine($"Converted string (\"3.14\") to double: {stringToDouble}\n");
        }
    }

    // Task 4: Array and Array Methods
    public class Task4
    {
        public static void Run()
        {
            Console.WriteLine("Task 4: Array and Array Methods");

            int[] favoriteNumbers = { 7, 21, 3, 42, 15 };

            Console.WriteLine("\nOriginal Array:");
            PrintArray(favoriteNumbers);

            Array.Sort(favoriteNumbers);
            Console.WriteLine("\nSorted Array (Ascending):");
            PrintArray(favoriteNumbers);

            Array.Reverse(favoriteNumbers);
            Console.WriteLine("\nReversed Array (Descending):");
            PrintArray(favoriteNumbers);

            Console.Write("\nEnter a number to find its index in the array: ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            int index = Array.IndexOf(favoriteNumbers, searchNumber);
            if (index >= 0)
                Console.WriteLine($"The number {searchNumber} is found at index {index}.\n");
            else
                Console.WriteLine($"The number {searchNumber} is not found in the array.\n");
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
                Console.Write(num + " ");
            Console.WriteLine();
        }
    }
    //Task 5:DateTime and Timespan
    public class Task5
    {
        public static void Run()
        {
            {
                Console.WriteLine("Task 5: DateTime and TimeSpan");

                //create a DateTime variable for birthDate
                DateTime birthDate = new DateTime(2005, 6, 15);

                //Create another DateTime for the current Date and time
                DateTime currentDate = DateTime.Now;

                //Calculate the age using TimeSpan
                TimeSpan ageSpan = currentDate - birthDate;
                int ageInYears = (int)(ageSpan.TotalDays / 365.25);

                //Display the results
                Console.WriteLine($"\nBirth Date: {birthDate.ToShortDateString()}");
                Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
                Console.WriteLine($"Age in Years: {ageInYears}\n");

                //Add 10 days to the birthDate
                DateTime newDate = birthDate.AddDays(10);
                Console.WriteLine($"Birth Date after adding 10 days: {newDate.ToShortDateString()}\n");
            }
        }
    }

    //Task 6: Generic collections and foreach loop

    public class Task6
    {
        public static void Run()
        {
            Console.WriteLine("Task 6: Generic List and Foreach Loop");

            //Create a List of Favorite Fruits
            List<string> favoriteFruits = new List<string>()
            {
                "Mango",
                "Banana",
                "Apple"
            };

            //Add a new fruit to the list
            favoriteFruits.Add("Orange");

            //Remove a fruit from the list
            favoriteFruits.Remove("Banana");

            //Display all fruits
            Console.WriteLine("\nFavorite Fruits List:");
            foreach (string fruit in favoriteFruits)
            {
                Console.WriteLine(fruit);
            }


            //Create a Dictionary of fruits id and names
                       Dictionary<int, string> fruitDictionary = new Dictionary<int, string>()
            {
                {1, "Mango" },
                {2, "Banana" },
                {3, "Apple" }
            };

            //Add a new fruit to the dictionary
            fruitDictionary.Add(4, "Pineapple");

            //Display all fruits in the dictionary
            Console.WriteLine("\nFruit Dictionary:");
            foreach (KeyValuePair<int, string> kvp in fruitDictionary)
            {
                Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            }
        }
    }
}


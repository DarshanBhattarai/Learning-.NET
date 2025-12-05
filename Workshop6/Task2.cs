using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Task2
    {
        // ----- PART 1 -------
        // Delegate for integer calculations
        public delegate int Calculate(int a, int b);

        // Add method
        public static int Add(int a, int b) => a + b;

        // Subtract method
        public static int Subtract(int a, int b) => a - b;


        // ------ PART 2 -------
        // Discount delegate
        public delegate double DiscountStrategy(double price);

        // Different discount methods
        public static double FestivalDiscount(double price) => price * 0.80; 
        public static double SeasonalDiscount(double price) => price * 0.90; 
        public static double NoDiscount(double price) => price;            
        // Method that accepts delegate as strategy
        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
            => strategy(originalPrice);


        // -------- RUN METHOD ----------
        public static void Run()
        {
            Console.WriteLine("--- PART 1: Delegate Calculation ---");

            // Using the Calculate delegate
            Calculate calcAdd = Add;
            Calculate calcSub = Subtract;

            Console.WriteLine($"Add(10, 5) = {calcAdd(10, 5)}");
            Console.WriteLine($"Subtract(10, 5) = {calcSub(10, 5)}");


            Console.WriteLine("\n--- PART 2: Discount Strategies ---");

            double price = 1000;

            Console.WriteLine($"Original Price: {price}");
            Console.WriteLine($"Festival Discount: {CalculateFinalPrice(price, FestivalDiscount)}");
            Console.WriteLine($"Seasonal Discount: {CalculateFinalPrice(price, SeasonalDiscount)}");
            Console.WriteLine($"No Discount: {CalculateFinalPrice(price, NoDiscount)}");

            // Lambda-based 30% discount
            Console.WriteLine("\n--- LAMBDA Discount (30%) ---");
            double lambdaDiscount = CalculateFinalPrice(price, p => p * 0.70);
            Console.WriteLine($"Lambda 30% Discount Price: {lambdaDiscount}");
        }
    }
}

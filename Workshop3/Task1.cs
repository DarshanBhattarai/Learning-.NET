using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3
{
    internal class Task1
    {
        public static void AddNumbers(int a, int b)
        {
            Console.WriteLine($"sum: {a + b}");
        }

        public static void SubtractNumbers(int a, int b)
        {
            Console.WriteLine($"difference: {a - b}");
        }
        public static void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine($"product: {a * b}");
        }
        public static void DivideNumbers(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"quotient: {a / b}");
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
        }
        public static void OddEvenFinder(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }

    }
}

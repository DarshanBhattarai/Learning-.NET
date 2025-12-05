using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Task3
    {
        // Method that accepts a Func<int, bool> delegate
        public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (var num in numbers)
            {
                if (condition(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

        // Run Task 3
        public static void Run()
        {
            int[] numbers = { 4, 7, 12, 18, 3, 25, 30, 9 };

            Console.WriteLine("--- Even Numbers ---");
            ProcessNumbers(numbers, n => n % 2 == 0);

            Console.WriteLine("\n--- Numbers Greater Than 10 ---");
            ProcessNumbers(numbers, n => n > 10);
        }
    }
}

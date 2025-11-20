using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3
{
    internal class Task5
    {
        public static  void SumOfN()
        {
            Console.WriteLine("Enter a number:");
            int n;
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"The sum of the first {n} numbers is: {sum}");
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer.");
            }
        }  
        public static void SumOfNum()
        {
            int i = 1;
            int sum = 0;
            while (i <= 20)
            {
                if (i % 4 == 0)
                {
                    i++;
                    continue; // skip multiples of 4
                }

                if (i == 15)
                {
                    Console.WriteLine("Stopping at 15...");
                    break; // stop loop
                }

                Console.Write(i + " ");
                i++;
            }
            Console.WriteLine($"\nSum of numbers from 1 to 20 is: {sum}");
        }

        public static void SumOfAll()
        {
            int[] numbers = {10,12,15,18,24,31 };
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"The sum of all numbers in the array is: {sum}");
        }
    }
}

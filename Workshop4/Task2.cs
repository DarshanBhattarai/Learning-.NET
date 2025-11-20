using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    internal class Task2
    {

        public void Add()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
        }

        public void Multiply()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number (press Enter for 1): ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine($"{num1} × 1 = {num1}");
            }
            else
            {
                int num2 = int.Parse(input);
                Console.WriteLine($"{num1} × {num2} = {num1 * num2}");
            }
        }
    }

}

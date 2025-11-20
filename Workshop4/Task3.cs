using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    internal class Task3
    {
        // Method with ref parameter
        public void Increase(ref int number)
        {
            number += 10;
        }
        // Method with out parameter
        public void GetFullName(out string fullName)
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            fullName = firstName + " " + lastName;
        }
        // sum all numbers
        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

    }
}

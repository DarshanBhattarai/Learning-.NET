using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3
{
    internal class Task3
    {
        public static void Age()
        {
            int age;
            if (int.TryParse(Console.ReadLine(), out age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Age cannot be negative.");
                }

                else if (age < 13)
                {
                    Console.WriteLine("You are a child.");
                }
                else if (age >= 13 && age < 20)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are an adult.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number for age.");
            }
        
        }
    }
}

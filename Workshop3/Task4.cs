using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3
{
    internal class Task4
    {
        public static void DayOfWeek()
        {
            int day;

            if (int.TryParse(Console.ReadLine(), out day))
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;

                    case 2: 
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                     case 5:
                        Console.WriteLine("Thursday");
                        break;
                     case 6:
                        Console.WriteLine("Friday");
                        break;
                     case 7:
                        Console.WriteLine("Saturday");
                        break;
                     default:
                        Console.WriteLine("Please enter a number between 1 and 7.");
                        break;  
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number for the day of the week.");
            }
        }
    }
}

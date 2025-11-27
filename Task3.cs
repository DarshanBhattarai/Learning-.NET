using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal class Task3
    {
        public class printer
        {
            public void Print(string message)
            {
                Console.WriteLine(message);
            }
            public void Print(int number)
            {
                Console.WriteLine(number);
            }
            public void Print(string message, int number)
            {
                for(int i=0; i<number; i++)
                {
                    Console.WriteLine($"[{i+1}] {message}");
                }
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3
{
    internal class Task2
    {

        public static void PerformanceNullCheck()
        {
            String username = null;

            //terneary operator to check 
            String message = username != null ? $"Hello, {username}!" : "Username is not available";
            Console.WriteLine(message);
            // Using null-coalescing operator
            String message2 = $"Hello, {username ?? "Guest"}!";
            Console.WriteLine(message2);

        }
    }
}

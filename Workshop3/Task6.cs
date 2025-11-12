using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3
{
    internal class Task6
    {
        public static void ConvertTointeger()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                // Attempt to convert to integer
                int number = Convert.ToInt32(input);

                Console.WriteLine($"You entered the number: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }
        public static void ValidatePassword()
        {
            try
            {
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                if (password.Length < 8)
                {
                    throw new Exception("Password must be at least 8 characters long.");
                }
                    Console.WriteLine("Password is valid."); }
                catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        } 
    }
}

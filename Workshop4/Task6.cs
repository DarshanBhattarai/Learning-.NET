using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    internal class Task6
    {
        public void Run()
        {
            Console.WriteLine("\n--- Task 6: Percentage Calculator (Debugging Practice) ---\n");

            int marks, total;

            // ---- INPUT SECTION ----
            Console.Write("Enter obtained marks: ");
            bool validMarks = int.TryParse(Console.ReadLine(), out marks);

            Console.Write("Enter total marks: ");
            bool validTotal = int.TryParse(Console.ReadLine(), out total);

            if (!validMarks || !validTotal || total == 0)
            {
                Console.WriteLine("Invalid input! Please enter valid integers (total cannot be zero).");
                return;
            }

          
            // 1st BREAKPOINT HERE
            double percentageWrong = marks / total * 100;  // integer division bug

        
            // 2nd BREAKPOINT HERE
           
            Console.WriteLine($"\nIncorrect Percentage (Bug Demo): {percentageWrong}%");

            //CORRECT CALCULATION
            double percentageCorrect = (double)marks / total * 100;
            Console.WriteLine($"Correct Percentage: {percentageCorrect}%");
        }
    }
}

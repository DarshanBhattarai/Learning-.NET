namespace Workshop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task1 Basic arithmetic operations
            Console. WriteLine("Task 1: Basic Arithmetic Operations");
            Task1.AddNumbers(10, 5);
            Task1.SubtractNumbers(10, 5);
            Task1.MultiplyNumbers(10, 5);
            Task1.DivideNumbers(10, 5);
            Task1.DivideNumbers(10, 0);
            Task1.OddEvenFinder(10);
            Task1.OddEvenFinder(7);


            //Task2 Null operators
            Console.WriteLine("\nTask 2: Null Operators");
            Task2.PerformanceNullCheck();

            // Task3 Age Calculator
            Console.WriteLine("\nTask 3: Age Calculator");
            Task3.Age();

            //Task4 Day of the week
            Console.WriteLine("\nTask 4: Day of the Week");
            Task4.DayOfWeek();

            //Task5 loops of numbers with switch expressions
            Console.WriteLine("\nTask 5: Loops of numbers with switch Expressions");
            Task5.SumOfN();
            Task5.SumOfNum();
            Task5.SumOfAll();

            //Task6 Try-Catch-Finally
            Console.WriteLine("\nTask 6: Try-Catch-Finally");
            Task6.ConvertTointeger();
            Task6.ValidatePassword();
        }

    }


}


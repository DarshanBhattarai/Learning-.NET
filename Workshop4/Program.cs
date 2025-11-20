using System;
using static Workshop4.Task1;

namespace Workshop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 
            Console.WriteLine("Task 1: Student Class Implementation\n");

            Student student1 = new Student("Ram Thapa", 20, "Computer Science");
            Student student2 = new Student("Hari Yadav", 22, "Mathematics");

            Console.WriteLine("Student 1 Details:");
            student1.DisplayDetails();
            Console.WriteLine();

            Console.WriteLine("Student 2 Details:");
            student2.DisplayDetails();
            Console.WriteLine();

            Console.WriteLine($"Total Students: {Student.GetTotalStudents()}");


            // Task 2
            Console.WriteLine("\nTask 2: Simple Calculator Implementation\n");

            Task2 task2 = new Task2();
            task2.Add();
            task2.Multiply();


            // Task 3
            Console.WriteLine("\nTask 3: Parameter Types\n");

            Task3 task3 = new Task3();

            int number = 5;
            Console.WriteLine($"Original number: {number}");
            task3.Increase(ref number);

            string fullName;
            task3.GetFullName(out fullName);
            Console.WriteLine($"Full Name: {fullName}");

            int sum = task3.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine($"Sum of all numbers: {sum}");


            // Task 4
            Task4 task4 = new Task4();
            task4.Run();

            //Task 5
            Console.WriteLine("\nTask 5: Enum and Record Types\n");
            Task5 task5 = new Task5();
            task5.Run();

            // Task 6 
            Task6 task6 = new Task6();
            task6.Run();

        }
    }
}

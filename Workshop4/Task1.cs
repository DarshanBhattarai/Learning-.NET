using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    internal class Task1
    {
        public class Student
        {
            // 3 instance fields
            private string name;
            private int age;
            private string major;

            // 1 static field
            private static int totalStudents = 0;

            // Constructor
            public Student(string name, int age, string major)
            {
                this.name = name;
                this.age = age;
                this.major = major;
                totalStudents++; // Increment static field when new student is created
            }

            // Method to display student details
            public void DisplayDetails()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Major: {major}");
            }

            // Static method to access static field
            public static int GetTotalStudents()
            {
                return totalStudents;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_5
{
    internal class Task4
    {
        // Base class
        public class Teacher
        {
            public string Name { get; set; }

            // Virtual method – can be overridden
            public virtual void Teaching()
            {
                Console.WriteLine("Teacher teaches in English");
            }

            // Sealed method – cannot be overridden by child classes
            public   void SalaryInfo()
            {
                Console.WriteLine("Salary information is confidential");
            }
        }

        // Derived class – overrides Teaching()
        public class NepaliTeacher : Teacher
        {
            public override void Teaching()
            {
                Console.WriteLine("Nepali Teacher teaches in Nepali");
            }
        }

        // Derived class – does not override Teaching()
        public class EnglishTeacher : Teacher
        {
            // Inherits Teaching() from base class
        }
    }
}

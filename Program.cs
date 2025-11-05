namespace Week2Workshop
{

    internal class Program
    {


        static void Main(string[] args)
        {
            //task 1
            String userName = "Darshan Bhattarai";
            int luckyNumber = 7;

            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

            //task 2 (1st process)
            const double PI = 3.14;
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = PI * radius * radius;
            double perimeter = 2 * PI * radius;
            Console.WriteLine($"For a circle with radius {radius}:");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");

            //task 2 (2nd process)
            Circle circle = new Circle();
            //Console.WriteLine($"For a circle with radius {radius}:");
            Console.WriteLine($"Area: {circle.CalculateArea(3)}");
            Console.WriteLine($"Perimeter: {circle.CalculatePerimeter(5)}");
        }


        //task 2 (2nd process)
        public class Circle
        {
            public const double PI = 3.14;
            public double CalculateArea(double radius)
            {
                return PI * radius * radius;
            }
            public double CalculatePerimeter(double radius)
            {
                return 2 * PI * radius;
            }
        }
    }
}



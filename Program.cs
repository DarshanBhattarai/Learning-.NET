using static Workshop_5.Task6;

namespace Workshop_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 Encapsulation
            Console.WriteLine("--- Task 1 Encapsulation ---");
            Task1.BankAccount account= new Task1.BankAccount("1AD332", 100000.00);
            Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");

            account.Deposit(50000.00);
            account.Withdraw(2000.00);
            Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance}");

            //Inheritance
            Console.WriteLine("\n--- Task 2 Inheritance ---");
            Task2.Car car = new Task2.Car
            {
                Brand = "Toyota",
                Speed = 120,
                Seats = 4
            };
            Task2.Motorcycle bike = new Task2.Motorcycle
            {
                Brand = "Harley Davidson",
                Speed = 100,
                HasCarrier = true
            };
            car.run();
            bike.run();


            //Polymorphism
            Console.WriteLine("\n--- Task 3 Polymorphism ---");
            Task3.printer printer = new Task3.printer();
            Console.Write("Enter a message to repeat: ");
            string repeatMessage = Console.ReadLine();

            Console.Write("Enter how many times to repeat: ");
            string countInput = Console.ReadLine();
            if (int.TryParse(countInput, out int count))
            {
                printer.Print(repeatMessage, count);
            }
            else
            {
                Console.WriteLine("Invalid count input!");
            }


            // Polymorphism base class and derived class
            Console.WriteLine("\n--- Task 4 Polymorphism with Inheritance ---")
            Task4.NepaliTeacher nepaliTeacher = new Task4.NepaliTeacher
            {
                Name = "Ram Bahadur"
            };
            Console.WriteLine($"Teacher Name: {nepaliTeacher.Name}");
            nepaliTeacher.Teaching();
            nepaliTeacher.SalaryInfo();

            Task4.EnglishTeacher englishTeacher = new Task4.EnglishTeacher
            {
                Name = "John Smith"
            };
            Console.WriteLine($"Teacher Name: {englishTeacher.Name}");
            englishTeacher.Teaching();
            englishTeacher.SalaryInfo();

            //Abstraction
            Console.WriteLine("\n--- Task 5 Abstraction ---");
            Task5.Car cars = new Task5.Car();
            Task5.Bike bikes = new Task5.Bike();

            Console.WriteLine("Car:");
            cars.StartEngine();
            cars.StopEngine();
            Console.WriteLine("Bike:");
            bikes.StartEngine();
            bikes.StopEngine();


            // OOPS
            Console.WriteLine("\n--- Task 5 OOPs ---");

            Task6.ElectronicsStore store =new Task6.ElectronicsStore();

            // Create devices
            Laptop laptop = new Laptop("Dell", 1200);
            Smartphone phone = new Smartphone("iPhone", 999);

            // Add devices to store
            store.AddDevice(laptop);
            store.AddDevice(phone);

            // Display info and child-specific behaviors
            store.ShowAllDeviceDetails();

        }
    }
}

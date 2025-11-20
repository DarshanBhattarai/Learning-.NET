using System;

namespace Workshop4
{
    internal class Task4
    {
        public string playerName;
        public int level;
        public int health;

        // Default constructor
        public Task4()
        {
            Console.WriteLine("Default constructor has been called");
        }

        // Parameterized constructor
        public Task4(string name, int lvl, int hp)
        {
            playerName = name;
            level = lvl;
            health = hp;
        }

        // Run method that handles all logic
        public void Run()
        {
            Console.WriteLine("\nTask 4: Player Class with Constructors\n");

            // Object using default constructor
            Task4 p1 = new Task4();
            Console.WriteLine("\nValues from p1 (default constructor):");
            Console.WriteLine($"Name: {p1.playerName}");
            Console.WriteLine($"Level: {p1.level}");
            Console.WriteLine($"Health: {p1.health}");

            // Get values for parameterized constructor
            Console.WriteLine("\nEnter player details:");

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter level: ");
            int level = int.Parse(Console.ReadLine());

            Console.Write("Enter health: ");
            int health = int.Parse(Console.ReadLine());

            // Creating parameterized object
            Task4 p2 = new Task4(name, level, health);

            Console.WriteLine("\nValues from p2 (parameterized constructor):");
            Console.WriteLine($"Name: {p2.playerName}");
            Console.WriteLine($"Level: {p2.level}");
            Console.WriteLine($"Health: {p2.health}");
        }
    }
}

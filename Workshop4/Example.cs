using System;

namespace Workshop4
{
    class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Car(string model, string color = "White")
        {
            Model = model;
            Color = color;
        }
    }

}

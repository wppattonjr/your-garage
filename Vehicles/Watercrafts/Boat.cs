using System;
using System.Collections.Generic;
using System.Text;
using YourGarage.Cars;

namespace YourGarage.Watercrafts
{
    class Boat
    {
        public FuelType FuelType { get; set; }
        public int PassengerOccupancy { get; set; }
        public Color Color { get; set; }


        public void Refueling()
        {
            Console.WriteLine($"The {PassengerOccupancy} passenger boat needs gas. It takes {FuelType} gas.");
        }

        public void Driving()
        {
            Console.WriteLine($"The {PassengerOccupancy} passenger boat has reached its destination and is ready to dock.");
        }
    }
}


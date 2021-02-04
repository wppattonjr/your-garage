using System;
using System.Collections.Generic;
using System.Text;
using YourGarage.Cars;

namespace YourGarage.Aircrafts
{
    class Airplane
    {
        public FuelType FuelType { get; set; }
        public int PassengerOccupancy { get; set; }
        public Color Color { get; set; }


        public void Refueling()
        {
            Console.WriteLine($"The {PassengerOccupancy} passenger aircraft needs gas. It takes {FuelType} gas.");
        }

        public void Flying()
        {
            Console.WriteLine($"The {PassengerOccupancy} passenger aircraft is flying vacationers to Tahiti");
        }

        public void Landing()
        {
            Console.WriteLine($"The {PassengerOccupancy} passenger aircraft has reached its destination and is ready to land.");
        }
    }
}

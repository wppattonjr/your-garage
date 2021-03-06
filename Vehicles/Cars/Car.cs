﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Cars
{
    class Car
    {
        public FuelType FuelType { get; set; }
        public int PassengerOccupancy { get; set; }
        public Color Color { get; set; }
        public FuelCapacity FuelCapacity { get; set; }

   
        public void Refueling()
        {
            Console.WriteLine($"The {Color} {PassengerOccupancy} passenger car takes {FuelType} and needs {FuelCapacity} gallons of gas. It takes {FuelType} gas.");
        }

        public void Driving()
        {
            Console.WriteLine($"The {Color} {PassengerOccupancy} passenger car is taking a family of four on a road trip");
        }

        public void Braking()
        {
            Console.WriteLine($"The {Color} {PassengerOccupancy} passenger car while on a road trip had to brake fast due to a family of ducks crossing the road.");
        }

    }

    

}

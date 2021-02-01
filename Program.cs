using System;
using YourGarage.Cars;

namespace YourGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.PassengerOccupancy = 5;
            car.FuelType = FuelType.Gasoline;
            car.Color = Color.Blue;

            car.Refueling();
            car.Driving();
            car.Braking();

        }
    }
}

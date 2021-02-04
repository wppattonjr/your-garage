using System;
using YourGarage.Cars;
using YourGarage.Aircrafts;
using YourGarage.Watercrafts;

namespace YourGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.PassengerOccupancy = 5;
            car.FuelType = FuelType.gasoline;
            car.Color = Color.blue;

            car.Refueling();
            car.Driving();
            car.Braking();

            var airplane = new Airplane();
            airplane.PassengerOccupancy = 250;
            airplane.Refueling();
            airplane.Flying();
            airplane.Landing();

            var boat = new Boat();
            boat.PassengerOccupancy = 35;
            boat.Refueling();
            boat.Driving();


        }
    }
}

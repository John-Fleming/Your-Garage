using System;
using System.Collections.Generic;
using YourGarage.Vehicles;
using YourGarage.Vehicles.Aircraft;
using YourGarage.Vehicles.Cars;
using YourGarage.Vehicles.Watercraft;

namespace YourGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            var f150 = new F150(VehicleColor.Red, 6, true);
            var prius = new Prius(VehicleColor.White);
            var united = new UnitedAirplane();
            var southwest = new SouthwestAirplane();
            var sailboat = new Sailboat();
            var jetski = new Jetski();

            var cars = new List<Car>();
            var planes = new List<Airplane>();
            var watercraft = new List<Watercraft>();

            cars.Add(f150);
            cars.Add(prius);
            planes.Add(united);
            planes.Add(southwest);
            watercraft.Add(sailboat);
            watercraft.Add(jetski);

            foreach (Car car in cars)
            {
                car.Drive();
            }

            foreach (Airplane plane in planes)
            {
                plane.Fly();
            }

            foreach (Watercraft oneWatercraft in watercraft)
            {
                oneWatercraft.Drive();
            }


            f150.Tailgate();
            sailboat.Refuel();
        }
    }
}

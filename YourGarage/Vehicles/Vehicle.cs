using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles
{
    abstract class Vehicle
    {
        public string FuelCapacity { get; set; }
        public VehicleColor VehicleColor { get; set; }
        public int PassengerCapacity { get; set; }

        public virtual void Refuel()
        {
            Console.WriteLine("Your vehicle is refueled.");
        }
    }
    enum VehicleColor
    {
        Black,
        White,
        Blue,
        Grey,
        Red,
        Green
    }
}

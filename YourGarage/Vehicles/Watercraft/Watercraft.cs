using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Watercraft
{
    class Watercraft : Vehicle
    {
        protected Watercraft(string fuelCapacity, VehicleColor vehicleColor, int passengerCapacity)
        {
            FuelCapacity = fuelCapacity;
            VehicleColor = vehicleColor;
            PassengerCapacity = passengerCapacity;
        }
        public override void Refuel()
        {
            Console.WriteLine("Watercraft is refueled.");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Sailing the high seas.");
        }
    }
}

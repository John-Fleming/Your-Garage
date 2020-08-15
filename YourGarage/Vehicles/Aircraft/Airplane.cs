using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Aircraft
{
    class Airplane : Vehicle
    {
        protected Airplane(string fuelCapacity, VehicleColor vehicleColor, int passengerCapacity)
        {
            FuelCapacity = fuelCapacity;
            VehicleColor = vehicleColor;
            PassengerCapacity = passengerCapacity;
        }
        public override void Refuel()
        {
            Console.WriteLine("Airplane is refueled.");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Soaring! Flying!");
        }

        public void Land()
        {
            Console.WriteLine("Doing the landing thing.");
        }
    }
}

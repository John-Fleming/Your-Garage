using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Cars
{
    abstract class Car : Vehicle
    {
        protected Car(string fuelCapacity, VehicleColor vehicleColor, int passengerCapacity)
        {
            FuelCapacity = fuelCapacity;
            VehicleColor = vehicleColor;
            PassengerCapacity = passengerCapacity;
        }

        public virtual void Drive()
        {
            Console.WriteLine("Rollin with the homies.");
        }

        public void Brake()
        {
            Console.WriteLine("Look out for that deer!");
        }
    }
}

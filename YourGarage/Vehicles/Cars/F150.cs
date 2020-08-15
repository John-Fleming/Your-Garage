using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Cars
{
    class F150 : Car
    {
        public bool ExtendedCab { get; set; }
        public F150(VehicleColor vehicleColor, int passengerCapacity, bool extendedCab) : base("24 gallons", vehicleColor, passengerCapacity)
        {
            ExtendedCab = extendedCab;
        }

        public override void Refuel()
        {
            Console.WriteLine("Your F-150 is refueled and will be empty again by the time you get home.");
        }

        public override void Drive()
        {
            Console.WriteLine($"Yeehaw! That {VehicleColor} F-150 makes Luke Bryan want to shake his hips.");
        }

        public void Tailgate()
        {
            if (ExtendedCab)
            {
                Console.WriteLine("Drinking a cold one with the bois in the back of this F150.");
            }
            else
            {
                Console.WriteLine("My truck is too small to party.");
            }
        }
    }
}

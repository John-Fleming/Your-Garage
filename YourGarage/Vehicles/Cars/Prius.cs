using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Cars
{
    class Prius : Car
    {
        public Prius(VehicleColor vehicleColor) : base("12 gallons", vehicleColor, 5)
        { }

        public override void Refuel()
        {
            Console.WriteLine("Your prius is refueled, but maybe you should consider going fully electric.");
        }

        public override void Drive()
        {
            Console.WriteLine($"You look pretty slick rolling up in your {VehicleColor} prius. The other parents in the carpool line are jealous.");
        }
    }
}

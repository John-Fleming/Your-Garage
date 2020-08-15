using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Watercraft
{
    class Sailboat : Watercraft
    {
        public Sailboat() : base("No need, my dude", VehicleColor.White, 20)
        { }

        public override void Refuel()
        {
            Console.WriteLine("No need to fuel up this sail boat, my dude.");
        }

        public void Sail()
        {
            Console.WriteLine("Ahoy! Sailing is for the elite.");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Watercraft
{
    class Jetski : Watercraft
    {
        public Jetski() : base("8 gallons", VehicleColor.Green, 2)
        { }

        public override void Drive()
        {
            Console.WriteLine($"Broseph! You know I rode the {VehicleColor} jetskis in Cabo! You Know! https://www.youtube.com/watch?v=7_Z3D1535Jo");
        }
    }
}

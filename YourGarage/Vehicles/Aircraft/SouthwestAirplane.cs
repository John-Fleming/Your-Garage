using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Aircraft
{
    class SouthwestAirplane : Airplane
    {
        public SouthwestAirplane() : base("200k liters", VehicleColor.Red, 150)
        { }

        public override void Fly()
        {
            Console.WriteLine("Thank you for flying Southwest, where we tell you jokes so you give us good customer service ratings!");
        }
    }
}

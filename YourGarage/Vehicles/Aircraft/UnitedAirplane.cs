using System;
using System.Collections.Generic;
using System.Text;

namespace YourGarage.Vehicles.Aircraft
{
    class UnitedAirplane : Airplane
    {
        public UnitedAirplane() : base("200k liters", VehicleColor.Blue, 150)
        { }

        public override void Fly()
        {
            Console.WriteLine("Thank you for flying United, where we will probably break and/or lose your belongings!");
        }
    }
}

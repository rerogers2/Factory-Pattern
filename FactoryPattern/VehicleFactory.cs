using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class VehicleFactory
    {
        // 2 motorcycle, 3 tricycle, 4 car/truck, 18 big rig
        public static IVehicle GetVehicle(string wheels)
        {
            switch (wheels)
            {
                case "2":
                    return new Motorcycle();
                case "3":
                    return new Tricycle();
                case "4":
                    return new CarTruck();
                case "18":
                    return new Bigrig();
                default:
                    return new NoVehicle();
            }
        }
    }
}

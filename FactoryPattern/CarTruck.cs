using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class CarTruck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new car/truck.");
        }
    }
}

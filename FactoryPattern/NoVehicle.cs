using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class NoVehicle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Sorry, there is no vehicle with that wheel type available.");
        }
    }
}

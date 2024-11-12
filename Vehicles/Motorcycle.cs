using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public Motorcycle(bool hasSideCar, string make, string model, int speed) : base(make, model, speed)
        {

        }  
    }
}

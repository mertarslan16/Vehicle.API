using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle.API.Models
{
    public class Car : Vehicle
    {
        public int Wheel { get; set; }
        public bool Headlight { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle.API.Models
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public Type Type { get; set; }
        public Color Color { get; set; }
    }
}
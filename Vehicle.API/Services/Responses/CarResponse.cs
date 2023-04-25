using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle.API.Services.Responses
{
    public class CarResponse
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public int Wheel { get; set; }
        public bool Headlight { get; set; }
    }
}
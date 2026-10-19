using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeisgnStruct
{
    public class LocationClass
    {
        public string Name { get; }
        public double DistanceInKM { get; }
        public LocationClass(string name, double distance) { Name = name; DistanceInKM = distance; }
    }
}

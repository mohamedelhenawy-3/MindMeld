using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UsingTuples
{
    public class FacilitesDistanceCalculator
    {

        private static readonly Random _random = new Random();
        public static Tuple<string,string> CalcFaciliriesDistance(string Facilityname)
        {
            return new Tuple<string,string>(Facilityname, Math.Round(_random.NextDouble() * 50, 1).ToString());
        }
        public static Tuple<string, string> CalcFaciliriesDistancev2(string Facilityname)
        {
            return Tuple.Create(Facilityname, Math.Round(_random.NextDouble() * 50, 1).ToString());
        }
        public static Tuple<string, double> CalcFaciliriesDistancev3(string Facilityname)
        {
            return Tuple.Create(Facilityname, Math.Round(_random.NextDouble() * 50, 1));
        }
    }
}

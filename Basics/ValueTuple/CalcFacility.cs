using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuples
{
    public class CalcFacility
    {

        private static readonly Random _random = new Random();
        public static ValueTuple<string, string> CalcFaciliriesDistance(string Facilityname)
        {
            return ValueTuple.Create<string, string>(Facilityname, Math.Round(_random.NextDouble() * 50, 1).ToString());
        }


        //implicit 
        public static (string, string)CalcFaciliriesDistancev2(string Facilityname)
        {
            return ValueTuple.Create<string, string>(Facilityname, Math.Round(_random.NextDouble() * 50, 1).ToString());
        }

        //explacit naems
        public static (string name, string distanceinkm) CalcFaciliriesDistancev3(string Facilityname)
        {
            return ValueTuple.Create<string, string>(Facilityname, Math.Round(_random.NextDouble() * 50, 1).ToString());
        }
    }
}

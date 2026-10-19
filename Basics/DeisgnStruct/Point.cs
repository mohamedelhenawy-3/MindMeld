using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeisgnStruct
{
    public class Point
    {
        public int x;


        public void TryChangeByValue(int val)
        {
            val = 99;
            Console.WriteLine($"-> Inside TryChangeByValue method, val is: {val}");
        }
        public void ChangeByRef(ref int val)
        {
            val = 99;
            Console.WriteLine($"-> Inside TryChangeByref method, val is: {val}");
        }

        public void ByOut(out Point p)
        {
            p = new Point {x = 5 }; // Mandatory assignment
            Console.WriteLine($"-> Inside TryChangeByout method, val is: {p.x}");
        }
    }
}

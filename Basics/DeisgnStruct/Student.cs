using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace DeisgnStruct
{
     struct Student
    {
        public string Name { get; set; }
        public  void Display()
        {
            Console.WriteLine($"name of student{Name}");
        }

      
    }
}

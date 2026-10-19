using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeisgnStruct
{
    public readonly record struct UserId
    {
        public readonly Guid Value;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_level_Vehicle
{
    partial class Car : Vehicle
    {
        public override string ToString()
        {
            string s = string.Format("This car {0} color!", Color);
            return s;
        }
    }
}

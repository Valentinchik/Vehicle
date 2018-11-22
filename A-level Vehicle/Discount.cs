using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_level_Vehicle
{
    interface IDiscount
    {
        int GetDiscount();
        int GetDiscount(string cardCode);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_level_Vehicle
{
    class Truck : Vehicle, ITruck, IDiscount
    {
        public Truck(int maxCapacity, string color, string model, int year, int price, bool leasePermit, int numberRrentalDays) : base(color, model, year, price, leasePermit, numberRrentalDays)
        {
            maximumCapacity = maxCapacity;
        }

        private int maximumCapacity;

        public int GetCountMaximumCapacity()
        {
            return maximumCapacity;
        }

        public int GetDiscount()
        {
            return Price - Price / 100 * 10;
        }

        public int GetDiscount(string cardCode)
        {
            return Price - Price / 100 * 25;
        }
    }
}

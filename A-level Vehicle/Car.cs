using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_level_Vehicle
{
    partial class Car : Vehicle, ICar, IDiscount
    {
        public Car(int passengers, string color, string model, int year, int price, bool leasePermit, int numberRrentalDays) : base(color, model, year, price, leasePermit, numberRrentalDays)
        {
            maxPassengers = passengers;
        }

        private int maxPassengers;

        public int GetCountMaximumCapacity()
        {
            return maxPassengers;
        }

        public int GetDiscount()
        {
            return Price - Price / 100 * 10;
        }

        public int GetDiscount(string cardCode)
        {
            return Price - Price / 100 * 15;
        }
    }
}

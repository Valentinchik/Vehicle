using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_level_Vehicle
{
    class Rent : IRent
    {
        private int NumberRrentalDays;
        private bool LeasePermit;
        private int Price;

        public Rent(int numberRrentalDays, bool leasePermit, int price)
        {
            NumberRrentalDays = numberRrentalDays;
            LeasePermit = leasePermit;
            Price = price;
        }

        public bool GetAccessRent()
        {
            return LeasePermit;
        }

        public int GetPriceRent()
        {
            if (!GetAccessRent())
                return 0;

            return (int)(Price / 12 * NumberRrentalDays * 0.01f);
        }
    }
}

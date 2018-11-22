using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_level_Vehicle
{
    class Vehicle
    {
        public string Color;

        public string Model;

        public int Year;

        public int Price;

        public bool LeasePermit = false;

        public int NumberRrentalDays = 0;

        public Vehicle(string _color, string _model, int _year, int _price, bool leasePermit, int numberRrentalDays)
        {
            Color = _color;
            Model = _model;
            Year = _year;
            Price = _price;
            LeasePermit = leasePermit;
            NumberRrentalDays = numberRrentalDays;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == GetType())
            {
                Vehicle v = obj as Vehicle;
                if(v.Color == Color && v.Year == Year && v.Model == Model)
                {
                    return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Year + Model.Length + Color.Length;
        }
    }
}
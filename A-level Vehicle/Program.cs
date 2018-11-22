using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_level_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(5, "red", "BMW", 1996, 2000, false, 100000);
            car.Color = "blue";
            Console.WriteLine(car.ToString());
            Console.ReadLine();
        }
    }
}

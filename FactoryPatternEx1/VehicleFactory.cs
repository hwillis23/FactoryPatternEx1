using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx1
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string rims)
        {
            switch(rims)
            {
                case "4":
                   return new Car();

                case "2":
                   return new Motorcycle();
                default:
                    return new Car();

            }

        }

    }
}

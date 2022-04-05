using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx1
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            Console.WriteLine($"When I am driving, this car goes vroom vroom!");

        }


    }
}

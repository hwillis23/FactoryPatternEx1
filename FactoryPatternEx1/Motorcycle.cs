using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternEx1
{
    public class Motorcycle : IVehicle
    {

        public Motorcycle()
        {
        }
        public void Drive()
        {
            Console.WriteLine($"I like to rev up my Chopper!!");

        }

    }

}

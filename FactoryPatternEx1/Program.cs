using System;

namespace FactoryPatternEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rims;
            Console.WriteLine("How many wheels does your vehicle have on it?");
            rims= Console.ReadLine();

            var vehicle = VehicleFactory.GetVehicle(rims);
            vehicle.Drive();
            
        }
    }
}

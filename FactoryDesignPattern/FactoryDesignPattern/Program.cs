using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Vehicle Type");
            string userinput = Console.ReadLine(); //bike or car

            IVehicle type = VehicleFactory.GetVehicle(userinput); // Factory Method

           
            Console.WriteLine("Vehicle Type is: " + type.VehicleType()); 
            Console.WriteLine("Number of Wheels is: "+ type.NumberOfWheels());

            Console.ReadLine();
        }
    }
}

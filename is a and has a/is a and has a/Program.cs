using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_a_and_has_a
{
    // has a relationship
    public class Engine
    {
        public void start1()
        {
            Console.WriteLine("Engine started");
        }
    }
    public class Car
    {
        Engine engine = new Engine();

        public void Drive()
        {
            engine.start1();
            Console.WriteLine("Car is driving");
        }
    }

    // is a relationship
    public class Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("engine is started");
        }
    }
    public class Bike : Vehicle
    {
        Vehicle v1 = new Vehicle();
        public void Start()
        {
            v1.Drive();
            Console.WriteLine("Bike started");
        }
    }




    internal class Program
    {
       
        static void Main(string[] args)
        {
            //has a relationship
            Car car = new Car();
            car.Drive();
           
            Console.WriteLine("------------------------------------");
            //is a relationship
            
            Bike b1 = new Bike();
            b1.Start();
           

            Console.ReadLine();
        }
    }
}

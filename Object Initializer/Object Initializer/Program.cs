using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializer
{
    class Person
    {
        public string Name { set; get; }
        public int Age { set; get; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Traditional Way of object Initialization
            Person p = new Person();
            p.Name = "Ramesh";
            p.Age = 21;
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);

            //Object Initializer ( explicit type)
            Person p2 = new Person
            {
                Name = "Suresh",
                Age = 22
            };
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Age);

            //Object Initializer ( var , implicit typing)
            var person = new Person
            {
                Name = "Mahesh",
                Age = 23

            };
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);


        }
    }
}

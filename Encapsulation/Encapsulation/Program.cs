using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation
{
    class Person
    {
        private string Name;
        private int Age;

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Name is Required.");
            }
            else
            {
                Name = name;
            }
        }
        public void GetName()
        {
            if(string.IsNullOrEmpty(Name) == true)
            {

            }
            else
            {
                Console.WriteLine("Your Name is: " + Name);
            }
        }


        public void SetAge(int age)
        {
            if ((Age > 0 ))
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Age Should Not be negative or zero");
            }
                
        }
        public void GetAge()
        {
            if (Age > 0)
            {
                Console.WriteLine("Your Age is: " + Age);
            }
            else
            {
              
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SetName("");
            p.SetAge(-1);
            p.GetName();
            p.GetAge();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInInheritance
{
    class BaseClass
    {
        public BaseClass(string mess)
        {
            Console.WriteLine("this is constructor of base class !!" + mess);
        }
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass() : base("hello c sharp")  
        {
            Console.WriteLine("this is constructor of derived class !!");

        }
    }

    public class A
    { 
        public A(string name)
        {
            Console.WriteLine("My name is: " + name);
        }
    }
    public class B : A
    {
        public B() : base("Jhon")
        {
            Console.WriteLine("child class constructor");
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            DerivedClass a = new DerivedClass(); // base class constructor will be called first

            Console.WriteLine("====================================================");

            B b = new B(); // base class constructor will be called first
            Console.ReadLine();
        }
    }
}

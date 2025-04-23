using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface A // interface declaration
    {
        // interface members are by default public and abstract
        void show(); // only declaration of method
    }
    class B : A
    { 
        public void show() // implementation of method
        {
            Console.WriteLine("i am method of interface class A");
        }
    }
    class C : A
    {
        public void show()
        {
            Console.WriteLine("i am method of interface class C");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
           // A a = new A();  can't create object of interface
           // a.show();
            B b = new B();
            b.show();
            C c = new C();
            c.show();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_InheritanceUsingInterface
{

    class A
    {
        public void show()
        {
            Console.WriteLine("parent Class A");
        }
    }
    interface B
    {
        void show();
    }
    class C : A, B
    {
        void B.show() // initialization of interface method
        {
            Console.WriteLine("method of interface B");
        }
    }

    public class X
    {
        public void print()
        {
            Console.WriteLine("class X parent class");
        }
    }
    interface Y
    {
        void show();
    }
    public class Z : X, Y
    {
        public void show()
        {
            Console.WriteLine("method of interface Y");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // instance of class A(parent class)
            A a = new A();
            a.show(); // call parent class method using parent class

            Console.WriteLine("------------------------------------------------");

            // instace of class C(child class)
            C c = new C();
            c.show();  // call parent class method using child class

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("------------------------------------------------");

            // instance of interface B for call interface method
            B b = new C();
            b.show();// call interface method using child class

            Console.WriteLine("------------------------------------------------");

            Z z = new Z();
            z.print(); // call parent class method using child class
            z.show(); // call interface method using child class

            Console.WriteLine("------------------------------------------------");

            Console.ReadLine();
        }
    }
}

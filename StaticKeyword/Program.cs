using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{

    //static class A
    //{
    //    static int x;
    //    static int y;

    //    static A()
    //    {
    //        x = 0;
    //        y = 0;
    //        Console.WriteLine("Static constructor called");
    //    }
    //    public static void setinfo(int a, int b)
    //    {
    //        x = a;
    //        y = b;
    //        Console.WriteLine("x:{0}", x);
    //        Console.WriteLine("y:{0}", y);
    //    }
    //}

    class B
    {
        int y;
        int z;
        static B()
        {
          
            Console.WriteLine("Static constructor of B called");
        }

        public B()
        {
            y = 1;
            z = 1;
            
            Console.WriteLine("Non static constructor of B called");
        }
        public void info(int y, int z)
        {
            this.y = y;
            this.z = z;
        }
        public void display()
        {
            Console.WriteLine("y:{0}", y);
            Console.WriteLine("z:{0}", z);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //call static constructor
            //A.setinfo(10, 20);
            //A.setinfo(30, 40);
            B b2 = new B();
            b2.info(10, 20);
            b2.display();

            //call non static class's static constructor
            B b1 = new B();
            b1.display();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentTypeOfVariable
{
    internal class Program
    {
        int a = 10; // non static variable
        int b; //// non static variable

        static int c = 100; // static variable
        static int d; // static variable

        const float pi = 3.14f;
        //const int e; // A const field requires a value to be provided

        class MyClass
        {
            public readonly int id;

            public MyClass(int id)
            {
                this.id = id; // allowed
            }

            public void ChangeId()
            {
                //id = 10; //Not allowed, compiler error
            }
        }
        static void Main(string[] args)
        {
            //non static variable
            Console.WriteLine("---------- non-static variable ----------");

            Program p1 = new Program(); // one instance have one copy  and multiple instance have multiple copy
            p1.a = 11; // modified value
            p1.b = 12; // initialize value
            Console.WriteLine("Modified value of a: " + p1.a);
            Console.WriteLine("initialize variable b after instance: " + p1.b);

            Console.WriteLine();
            Console.WriteLine("---------- static variable ----------");

            //using without instance creation
            Program.c = 101; // modified value
            Program.d = 102; // initialize  value
            Console.WriteLine("Modified value of c: " + c);
            Console.WriteLine("initialize variable d: " + d);

            Console.WriteLine();
            Console.WriteLine("---------- Constant variable ----------");

            //using without instance creation // only single copy
            // not initialize value 
            //Program.pi = 3.15f; // not - modified value 
            Console.WriteLine("Value of const variable pi is: "+ pi);

            Console.WriteLine();
            Console.WriteLine("---------- readonly variable ----------");

            // 0 instance = 0 copies, N instance = N copies
            MyClass m1 = new MyClass(12);
            Console.WriteLine("value of readonly variable is: " + m1.id);

            



        }
    }
}

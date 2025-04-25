using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct program
    {
        public int a; // default value of a is 0
        public void fun1()
        {
            Console.WriteLine("Hello World");
        }
    
    }
    class program1
    {
        public int b; // default value of a is 0
        public void fun2()
        {
            Console.WriteLine("Hello World");
        }
    }
    // Structs are value types, while classes are reference types.

    internal class Program
    {
        static void Main(string[] args)
        {
            // object of struct 
            Console.WriteLine("----------- output of struct ----------");
            program p1 = new program(); // new keyword is used here to create an instance of the struct  , new keyword is not used than struct has not default constructor
            p1.fun1();
            Console.WriteLine("value of a: " + p1.a); // a is 0 by default
            p1.a = 10; // we can assign value to a
            Console.WriteLine("value of a: " + p1.a); // a is 10 by default


            Console.WriteLine("----------- output of class ----------");

            // object of class  // new keyword is compulsory to create an instance of the class
            program1 p3 = new program1(); // new keyword is used here to create an instance of the class and it is necessary
            p3.fun2();
            Console.WriteLine("default value of b is: " + p3.b); // b is 0 by default
            p3.b = 10; // we can assign value to b
            Console.WriteLine("value of b: " + p3.b); // b is 10 by default
            Console.ReadKey();      
        }

    }
}

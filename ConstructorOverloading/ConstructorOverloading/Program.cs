using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    internal class Program
    {
        // Constructor Overloading
        public Program()
        {
            Console.WriteLine("This is First Constructor");
        }
        public Program(int a, int b)
        {
            Console.WriteLine("This is second Constructor {0}",(a+b));
        }

        public Program(int a, int b, int c)
        {
            Console.WriteLine("This is third Constructor {0}", (a + b + c));
        }
        static void Main(string[] args)
        {
            // Costructor name is same but parameter list is different it is called constructor overloading
            // create object of class
            Program p = new Program(); // default constructor called
            Program p1 = new Program(1,2); // parameterized constructor called
            Program p2 = new Program(1, 2, 3); // parameterized constructor called
            Console.ReadLine();
        }
    }
}

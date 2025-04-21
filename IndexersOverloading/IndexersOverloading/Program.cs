using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersOverloading
{
    class A
    {

        private int[] Age = new int[5];

        public int this[int index]
        {
            set
            {
                // Check if the index is within the bounds of the array
                if (index >= 0 && index < Age.Length)
                {
                    // Check if the value is positive
                    if ((value > 0))
                    {
                        Age[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("Age cannot be negative or zero");
                    }

                }
                else
                {
                    Console.WriteLine("Index out of range");
                }
            }

            get
            {
                return Age[index];
            }
        }
        public int this[int index, int i]
        {
            set
            {
                Age[index] = value + i;

            }
            get
            {
                return Age[index];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            // Using the first indexer
            // indexer with one parameter
            a[0] = -10; // This will trigger the negative age message
            a[1] = 20;
            a[2] = 30;
            a[3] = 40;
            a[4] = 50;
            a[5] = 60; // This will trigger the index out of range message
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);

            Console.WriteLine("**************************************************");

            // performing indexer overloading
            // Using the second indexer  
            // indexer with two parameters
            a[0, 1] = 10; // This will set Age[0] to 11 , value + i = 10 + 1
            a[1, 2] = 20; // This will set Age[1] to 22 , value + i = 20 + 2
            a[2, 3] = 30; // This will set Age[2] to 33 , value + i = 30 + 3
            a[3, 4] = 40; // This will set Age[3] to 44 , value + i = 40 + 4
            a[4, 5] = 50; // This will set Age[4] to 55 , value + i = 50 + 5

            Console.WriteLine(a[0]); // This will print 11
            Console.WriteLine(a[1]); // This will print 22
            Console.WriteLine(a[2]); // This will print 33
            Console.WriteLine(a[3]); // This will print 44
            Console.WriteLine(a[4]); // This will print 55


            Console.ReadLine();
        }
    }
}

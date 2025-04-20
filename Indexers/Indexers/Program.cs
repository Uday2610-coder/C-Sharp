using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
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

            Console.ReadLine();
        }

    }
}

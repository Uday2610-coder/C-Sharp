using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_and_out
{
    internal class Program
    {
        // pass by value
        public static void PassByValue(int a)
        {
            a = a + 10;
            Console.WriteLine("value is:" + a);
        }

        // pass by reference
        public static void PassByRef(ref int a)
        {
            a = a + 10;
            Console.WriteLine("value of a is: " + a);
        }

        // pass by out
         
        public static void PassByOut(out int a)
        {
            a = 10;
            Console.WriteLine("value of a is: " + a);

        }
        static void Main(string[] args)
        {
            // pass by value
            int value = 5;
            PassByValue(value); // calling static method 
            Console.WriteLine("int value = "+value);
            Console.WriteLine("---------------------------------");

            // pass by reference  
            int value2 = 5; // this variable value change and value2 = 15
            PassByRef(ref value2); // passing refrence of value in method
            Console.WriteLine("int value2 = " + value2);
            Console.WriteLine("---------------------------------");

            //Pass by out
            int value3;
            PassByOut(out value3); // passing out variable
            Console.WriteLine("int value3 = " + value3);
            Console.WriteLine("---------------------------------");


            Console.ReadLine();


        }
    }
}

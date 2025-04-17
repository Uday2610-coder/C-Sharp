using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_and_Dynamic_keyword
{
    class A
    {
        public  dynamic add (dynamic i, dynamic j)
        {
            dynamic sum = i + j;
            Console.WriteLine($"sum of two dynamic variable is: {sum}");
            return sum;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // var keyword , not change value when once initialize
            var a = 20;
            Console.WriteLine("value of a: "+ a);
            Console.WriteLine("TypeOf a: " + a.GetType());
            var b = "Uday";
            Console.WriteLine("value of b: " + b);
            Console.WriteLine("TypeOf b: " + b.GetType());
            Console.WriteLine("Convert toUpper : "+ b.ToUpper());
            Console.WriteLine("Get Length Of String: " + b.Length);

            Console.WriteLine("------------------------------------------------");

            // Dynamic keyword

            dynamic A; // no need to initialize

            dynamic B = "Uday";
            Console.WriteLine("B value is: " + B);
            B = "UMistry";// change value of B
            Console.WriteLine("before changing data type is: "+ B.GetType());
           
            B = 1; // change value and dataType
            Console.WriteLine($"after changing value is: {B} and datatype is: {B.GetType()}");

            Console.WriteLine("------------------------------------------------");
            // using dynamic keyword we can pass in parameter any data type
            A a1 = new A();
            a1.add(10, 20);
            A a2 = new A();
            a2.add("Uday", " Mistry");
        }
    }
}

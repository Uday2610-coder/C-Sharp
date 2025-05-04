using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public delegate void MyDelegate(int num);
    public delegate int MyDelegate2(int num);

    public delegate int MyDelegate3(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------Statement Lambda-----------------------

            // ----------no return type----------
            //MyDelegate obj =  (a) => 
            //{
            //    a += 5;
            //    Console.WriteLine(a);
            //};
            //    obj.Invoke(5);

            //---------- return type ----------

            //MyDelegate2 obj = (a) =>
            //{
            //    a += 5;
            //    return a;
            //};
            //Console.WriteLine(obj(5));

            //----------------------Expression Lambda-----------------------

            //MyDelegate2 obj2 = (a) => a * a;
            //MyDelegate2 obj3 = (a) => a * a * a;


            //Console.WriteLine(obj2.Invoke(5));
            //Console.WriteLine(obj3.Invoke(5));

            //int square = obj2(10);
            //int qube = obj3(10);
            //Console.WriteLine(square);
            //Console.WriteLine(qube);

            //MyDelegate3 obj4 = (a, b) => a + b;
            //Console.WriteLine(obj4(10,25));

            Console.ReadLine();
        }
    }
}

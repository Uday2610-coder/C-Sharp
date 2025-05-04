using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
   
    public delegate void MyDelegate(int Num); //return type void

    public delegate int MyDelegate2(int Num); //return type int

    public delegate void Mydel(int num);

   
    class Program
    {
        // anonymous method use as a perameter
        public static void MyMethod(Mydel del,int a)
        {
            a += 10;
            del.Invoke(a); //in anonymous method passing 'a' value in b ;
        }

        static void Main(string[] args)
        {
            // Anonymous Function always use with delegates

            MyDelegate obj = delegate (int a)
            //anonymous method with no return type
            {
                a += 10;
                Console.WriteLine(a);
            };
            obj.Invoke(10);
            obj(20);

            MyDelegate2 obj1 = delegate (int a)
            //Anonymous method with return type
            {
                a += 10;  //after calling function a value is 15
                return a;
            };
            Console.WriteLine(obj1.Invoke(10));
            Console.WriteLine(obj1(20));


            //Anonymous method use as a parameter
            Program.MyMethod(delegate (int b)
            { b += 10; Console.WriteLine("value of b = " + b); }
            , 5);  // a value is 5 

            Console.ReadLine();
        }
    }
}

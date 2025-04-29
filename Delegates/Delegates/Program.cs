using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    // example of single-cast delegate , one method is assigned to one delegate
    public delegate void Calc(int num1, int num2); // delegate declaration

    class Delegate
    {
        public static void addition(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition of two numbers  is: {0}", result);
        }
    }

    //example of multi-cast delegate, one delegate is assigned to multiple methods
    public delegate void Calculation(int a, int b);


    // example of multiple delegates
    public delegate void show_delegate();
    public delegate void Calculation2(int num);

    class Program
    {
        public static void square(int num)
        {
            int square = num * num;
            Console.WriteLine("Square of {0} is {1}", num ,square);
        }
        public static void cube(int num)
        {
            int cube = num * num * num;
            Console.WriteLine("Cube of {0} is {1}", num, cube);
        }
        public static void show()
        {
            Console.WriteLine("Hello from show method");
        }
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is: {0}", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication result is: {0}", result);
        }
        public  void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is: {0}", result);
        }
        public static void Subtraction(int a, int b)  
        {
            int result = a - b;
            Console.WriteLine("Subtraction result is: {0}", result);
        }
        static void Main(string[] args)
        {
            // Creating delegate instance for static method
            Calculation calc = new Calculation(Program.Addition);  // calling static method using delegate , passing reference of method in delegate
            calc.Invoke(2, 4);     // Invoking the delegate
            calc = Multiplication; // assigning another method to delegate
            calc(2, 4);            // or another way to invoke the delegate

            Calculation calc2 = new Calculation(Program.Subtraction); // creating another delegate instance
            calc2(5, 2); // calling the delegate

            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("");

            // Creating delegate instance for instance method
            Program p = new Program();
            Calculation calc3 = new Calculation(p.Division); // creating delegate instance for instance method
            calc3.Invoke(10, 2); // invoking the delegate
            calc3 = Multiplication;
            calc3(10, 2); // invoking the delegate

            Console.WriteLine("");
            Console.WriteLine("--------------- miltiple delegates ---------------");
            Console.WriteLine("");

            show_delegate s1 = new show_delegate(show); // creating delegate instance for static method
            s1.Invoke(); // invoking the delegate

            Calculation2 cal2 = new Calculation2(square);
            cal2.Invoke(5); // invoking the delegate

            cal2 = cube; // assigning another method to delegate
            cal2.Invoke(5); // invoking the delegate\

            Console.WriteLine("");
            Console.WriteLine("--------------- single-cast delegaste ---------------");
            Console.WriteLine("");

            Calc c1 = new Calc(Delegate.addition); // creating delegate instance for static method
            c1(2, 4); // invoking the delegate

            Console.WriteLine("");
            Console.WriteLine("--------------- multi-cast delegates ---------------");
            Console.WriteLine("");

            Calculation calc4 = new Calculation(Addition);
            calc4 += Multiplication; // adding another method to delegate
            calc4 -= Subtraction; // -= means removing the method from delegate
            calc4(150, 100); // this value will be passed to all methods

            Console.ReadLine();

        }
    }
}

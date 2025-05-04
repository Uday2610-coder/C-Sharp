 using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Exception_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------DivideByZeroException Handling---------------

            //Console.WriteLine("Enter First number: "); //as a input 10
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second number: "); //as a input 0
            //int num2 = int.Parse(Console.ReadLine());
            //try
            //{
            //    int result = num1 / num2; // exception can occure here
            //    Console.WriteLine("Devision Result is: " + result);
            //}
            //catch(DivideByZeroException ex) // if exception happen that time this catch block will be execute
            //{
            //    Console.WriteLine("you can't divide a number by zero....");
            //    Console.WriteLine(ex.Message); //ex is a variable name and it use to show error messege
            //}


            //// if exception handling not use than after exception this below code will be not run  
            //Console.WriteLine("Remaining statement 1");
            //Console.WriteLine("Remaining statement 2");
            //Console.WriteLine("Remaining statement 3");

            //---------------Handling Index Out of Range Exception---------------

            //int[] arr = new int[3];
            //try
            //{
            //    arr[0] = 11;
            //    arr[1] = 22;
            //    arr[2] = 33;
            //    arr[3] = 44;

            //    foreach (int i in arr)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Array's range is Exceeded.....");
            //    Console.WriteLine(ex.Message);
            //}

            //---------------Null Reference Exception---------------

            //try
            //{
            //    string name = null;
            //    Console.WriteLine(name.Length);
            //}
            //catch(NullReferenceException ex)
            //{
            //    Console.WriteLine("String is null.....");
            //    Console.WriteLine(ex.Message);
            //}

            //---------------Format Exception---------------

            //Console.WriteLine("Enter a number: ");
            //string number = Console.ReadLine();

            //try
            //{
            //    int num = int.Parse(number); // also we can  use Convert.ToInt32 
            //    Console.WriteLine("Number is: " + num); // if i ente character than exception happen
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine("String Format is Invalid.....");
            //    Console.WriteLine(ex.Message);
            //}

            //---------------Exception class---------------

            // we can handling all type of Exceptions using Exception class

            //int a = 10;
            //int b = 0;
            //try
            //{
            //    int result = a / b; //DivideByZeroException
            //    Console.WriteLine(a);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
           
            //try
            //{
            //    string name = null;//NullRefrenceException
            //    Console.WriteLine(name.Length);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    string a = "Uday";
            //    int i = int.Parse(a); //FormateException

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Console.ReadLine();

        }
    }
}

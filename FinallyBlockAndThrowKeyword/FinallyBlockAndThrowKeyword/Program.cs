using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyBlockAndThrowKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------------------Finally Keyword------------------------------

            //finally block always executes whether execption occurs or not

            //---------------exception not occurs---------------

            //try
            //{
            //    int a = 12;
            //    int b = 6;
            //    int c = a / b;
            //    Console.WriteLine(c);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Block Execute....");
            //}


            //--------------execption occurs-------------

            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    int c = a / b;
            //    Console.WriteLine(c);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally block Executed....");
            //}

            //---------------no catch block only finally block---------------
            // if we can't declare catch block but declare finally block that time also run finally keyword
            // if you want to show output than start without debugging code and that time exception handle automatically by C#

            //try
            //{
            //    string name = null;
            //    Console.WriteLine(name.Length);
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Block Execute...");
            //}


            //------------------------------ Throw Keyword -----------------------------


            //----------our throw and default catch----------

            //Console.Write("Enter Your age: ");
            //int age = int.Parse(Console.ReadLine());

            //if(age >= 18)
            //{
            //    Console.WriteLine("You are eligible to vote........");
            //}
            //else
            //{
            //    throw new Exception("You are not eligible to vote........");
            //}


            //----------our throw and our catch----------


            //Console.Write("Enter Your age: ");
            //int age = int.Parse(Console.ReadLine());

            //try
            //{
            //    if (age >= 18)
            //    {
            //        Console.WriteLine("You are eligible to vote........");
            //    }
            //    else
            //    {
            //        throw new Exception("You are not eligible to vote........");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //int account_balance = 10000;
            //Console.WriteLine("Your balance is: " + account_balance);
            //Console.WriteLine("Enter Withdrawl amount..");
            //int withdrawl_amount = Convert.ToInt32(Console.ReadLine());
            //try
            //{
            //    if (account_balance < withdrawl_amount)
            //    {
            //        throw new Exception("Insufficient Balance...");
            //    }
            //    else
            //    {
            //        account_balance = account_balance - withdrawl_amount;
            //        Console.WriteLine("Remaining Balance is: " + account_balance);
            //        Console.WriteLine("Transaction completed successfully.....");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            
            Console.ReadLine();
        }
    }
}

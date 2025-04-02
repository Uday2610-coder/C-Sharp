using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionStatement
{
    internal class conditionStatement
    {
        static void Main(string[] args)
        {

            // if Statement

            System.Console.WriteLine("Uday.....");
            int PIN = 122;

            if(PIN == 1122)
            {
                Console.WriteLine("Address: Old Bharuch, Bharuch, Gujarat");
            }
            System.Console.WriteLine("8864545289");


            //if - else statement

            if(PIN == 12)
            {
                System.Console.WriteLine("Address: Old Bharuch, Bharuch, Gujarat");
            }
            else
            {
                System.Console.WriteLine("Wrong PIN");
            }

            //else - if statement

            int marks =57;

            System.Console.Write("You are ");

            if(marks>=80 && marks<=100)
            {
                System.Console.Write("Topper!");
            }
            else if(marks >= 79 && marks <= 60)
            {
                System.Console.Write("Good Score!");
            }
            else if (marks >= 59 && marks <= 40)
            {
                System.Console.Write("Just Pass!");
            }
            else
            {
                System.Console.Write("Everage!");

            }

            // nested if statement

            System.Console.Write(" and Your Grade is ");

            if(marks >= 60 && marks <= 100)
            {
                if(marks >= 80 && marks <= 100)
                {
                    System.Console.Write("A");
                }
                else if(marks >= 79 && marks >= 60)
                {
                    System.Console.Write("B");
                }
            }
            else
            {
                System.Console.Write("C");
            }

            //switch statment
            
            int ch; 
            Console.WriteLine("\nEnter your choice");
            ch = Convert.ToInt32(Console.ReadLine());
            
            switch(ch)
            {
                case 1: Console.WriteLine("Uday");
                    break;
                case 2: Console.WriteLine("Mistry");
                    break;
                default : Console.Write("INvalid User Input!");
                    break;
            }
        }
    }
}

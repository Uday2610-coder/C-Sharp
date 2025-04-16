using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class parent
    {
        public void show()
        {
            Console.WriteLine("Parent class method");
        }
    }
    public class child : parent
    {
        public new void show()
        {
            base.show(); // Calls the parent class method
            //Console.WriteLine("child class method");
        }
    }

    class employee
    {
        public string firstName;
        public string lastName;
        public void printFullName()
        {
            Console.WriteLine(firstName+ " " + lastName);
        }
    }
    class partTimeEmployee : employee
    {
        public new void printFullName()
        {
            base.printFullName();// Calls the base class method
            //Console.WriteLine(firstName + " " + lastName + "PTE");
        }
    }
    class fullTimeEmployee : employee
    {
        public new void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + "FTE");
        }
    }

    class A
    {
        public void show()
        {
            Console.WriteLine("A class method");
        }
    }
    class B : A
    {
        public void show()
        {
            base.show(); // Calls the A class method
            //Console.WriteLine("B class method");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            child c = new child(); 
            c.show();  // give output of parent class method using base keyword

            Console.WriteLine("------------------------------------------");


            ((parent)c).show(); // Calls the parent class method using casting

            Console.WriteLine("------------------------------------------");

            parent p = new child();
            p.show(); // Calls the parent class method using polymorphism 

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------------------------------------------");

           
            partTimeEmployee pte = new partTimeEmployee();
            pte.firstName = "Uday";
            pte.lastName = "Mistry ";
            pte.printFullName();

            Console.WriteLine("-------------------------------------------");

            // if you want to call parent class method
            // using polymorphism
            employee fte = new partTimeEmployee();
            fte.firstName = "Uday";
            fte.lastName = "Mistry ";
            fte.printFullName(); // call the parent class method using polymorphism

            Console.WriteLine("-------------------------------------------");

            //using casting
            partTimeEmployee pte1 = new partTimeEmployee();
            pte1.firstName = "Uday";
            pte1.lastName = "Mistry ";
            ((employee)pte1).printFullName(); // Calls the parent class method using casting

            Console.WriteLine("-------------------------------------------");

            //using base keyword
            partTimeEmployee fte1 = new partTimeEmployee();
            fte1.firstName = "Uday";
            fte1.lastName = "Mistry ";
            fte1.printFullName(); // call the parent class method using base keyword

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("-------------------------------------------");

            A a = new A();
            a.show(); // Calls the A class method

            B b = new B();
            b.show(); // Calls the B class method

            A ab = new B();
            ab.show(); // Calls the A class method using polymorphism



            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class parent
    {
        public  void print()
        {
            Console.WriteLine("This is a method of parent class");
        }

    }
    class child : parent
    {
        public void print()
        {
            Console.WriteLine("This is a method of child class"); 
        }
    }

    class sum
    {
        public void add()
        {
            Console.WriteLine("nothing to add");
        }

        public void add(int a)
        {

            Console.WriteLine("your sum of number is : " + a);
           
        }

        public void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Your sum of two numbers is: " + c);
        }
    }

    class A
    {
        public virtual void  print()
        {
            Console.WriteLine("A class");
        }

    }
    class B : A
    {
        public override void print()
        {
            Console.WriteLine("B class");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
           parent c = new child();
            c.print();
            

            sum s1 = new sum();
            s1.add();

            Console.ReadLine();
        }
    }
}

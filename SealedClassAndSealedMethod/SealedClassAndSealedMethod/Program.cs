using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassAndSealedMethod
{
    //sealed class
    sealed class ParentClass
    {
        public void Show1()
        {
            Console.WriteLine("ParentClass Show1");
        }
    }
    /*class ChildClass : ParentClass // error CS0509: 'ChildClass' cannot derive from sealed type 'ParentClass'
 
    {
        public void Show2()
        {
            Console.WriteLine("ChidClass Show2");
        }
    }*/

    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("This is a method of class A!!");
        }
    }
    class B : A
    {
        public sealed override void Print()
        {
            Console.WriteLine("This is a method of class B!!");
        }
    }

  /*  class C : B // canno't override because class B use sealed keyword
    {
        public override void Print()
        {
            Console.WriteLine("This is a method of class C!!");
        }
    }*/

    internal class Program
    {
         static void Main(string[] args)
         {
            //ChildClass c1 = new ChildClass();
            //c1.Show1(); // seald class never be inherited

            A objA = new A();
            objA.Print();  // Output: This is a method of class A!!

            B objB = new B();
            objB.Print();  // Output: This is a method of class B!!

            A objAB = new B();
            objAB.Print(); // Output: This is a method of class B!! (runtime polymorphism)

            Console.ReadLine();
         }
    }
}

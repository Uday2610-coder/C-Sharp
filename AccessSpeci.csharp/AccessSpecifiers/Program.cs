using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    //Consuming members of a class from same class
    public class Program
    {
        private void test1()
        {
            Console.WriteLine("Private method");
        }
       internal void test2()
        {
            Console.WriteLine("Internal method");
        }
        protected void test3()
        {
            Console.WriteLine("Protected method");
        }
        protected internal void test4()
        {
            Console.WriteLine("Protected Internal method");
        }
        public void test5()
        {
            Console.WriteLine("Public method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.test1(); // This will not work because test1 is private
            p.test2(); // This will work because test2 is internal
            p.test3(); // This will not work because test3 is protected
            p.test4(); // This will work because test4 is protected internal
            p.test5(); // This will work because test5 is public
            Console.ReadLine();

        }
    }
}

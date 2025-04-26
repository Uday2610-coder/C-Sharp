
using DllClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using exteMethod;


namespace ExtensionMethod
{
    class TestExtensionMethod
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Func1();
            p.Func2();
            p.Func3(); // Calling the extension method


            Library ob = new Library();  // Creating an object of the Library class
            ob.Func1();
            ob.Func2();
            ob.Func3();
            ob.Func4();
            ob.Func5(); // Calling the extension method

            Console.ReadLine();
        }
    }
}

namespace exteMethod
{
    static class ExteMethod
    {
        // This is an extension method for the Library class
        public static void Func5(this Library ob)
        {
            Console.WriteLine("This is extension method");
        }
    }

}

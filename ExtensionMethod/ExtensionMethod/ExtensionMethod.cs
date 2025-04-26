using DllClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    static class ExtensionMethod
    {
        public static void Func3(this Program p)
        {
            Console.WriteLine("This is third function from ExtensionMethod......");
        }
    }
}


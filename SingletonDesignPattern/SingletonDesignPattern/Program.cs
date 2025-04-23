using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = MyClass.GetInstance();
            MyClass m1 = MyClass.GetInstance();
            MyClass m2 = MyClass.GetInstance();
            MyClass m3 = MyClass.GetInstance();
            MyClass m4 = MyClass.GetInstance();
            MyClass m5 = MyClass.GetInstance();
            MyClass m6 = MyClass.GetInstance();
            MyClass m7 = MyClass.GetInstance();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_and_Unboxing
{
    internal class boxing_unboxing
    {
        static void Main(string[] args)
        {
            // boxing - converting a value type to an refrence type
            //implicitly converting a value type to a reference type
            int num = 10; // value type
            object obj = num; // reference type
            Console.WriteLine(obj); // Output: 10
            // unboxing - converting an refrence type back to a value type
            //explicitly converting a reference type to a value type
            int num1 = (int)obj; // unboxing
            Console.WriteLine(num1); // Output: 10
        }
    }
}

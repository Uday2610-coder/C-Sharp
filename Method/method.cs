using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class method
    {
        static void Greet(string name)
        {
            Console.WriteLine("Good Morning " + name);
        }
        static float  Average(float a, float b, float c)
        {
            float sum = a + b + c;
            return sum/ 3;
        }
        static void Main(string[] args)
        {
            // method = function
            Greet("Uday");
            Greet("Dev");

            Console.WriteLine(Average(1, 2, 3));
            Console.WriteLine(Average(3, 2, 3));

            float temp = Average(6, 6, 6);
            Console.WriteLine(temp);


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class operators
    {
        static void Main(string[] args)
        {
            //Operators
            /*
            1.ArithmericOPerators
            2.AssignmentOperators
            3.LogicalOperators
            4.CompsrisonOperators
            */


            //1.ArithmericOPerators
            int a = 4;
            int b = 5;
            Console.WriteLine("The values of a + b is : " + (a + b));
            Console.WriteLine("The values of a + b is : " + (a - b));
            Console.WriteLine("The values of a + b is : " + (a * b));
            Console.WriteLine("The values of a + b is : " + (a / b));



            //2.AssignmentOperators
            int c = 4;
            int d = c;

           // d -= 4;
           // d += 4;
           // d *= 4;
           // d /= 4;
            System.Console.WriteLine(d);


            //3.LogicalOperators

            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);

            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            Console.WriteLine(!false);
            Console.WriteLine(!true);

            //4.CompsrisonOperators

            System.Console.WriteLine(322 > 22222);
            System.Console.WriteLine(322 < 22222);
            System.Console.WriteLine(322 >= 22222);
            System.Console.WriteLine(322 <= 22222);
            System.Console.WriteLine(322 != 322);
            System.Console.WriteLine(322 == 322);
        }
    }
}

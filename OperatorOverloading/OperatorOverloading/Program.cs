using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Program
    {
        class matrix
        {
            public int a, b, c, d;
            public matrix (int a, int b, int c, int d)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
            }

            public override string ToString()
            {
                return a + " " + b + "\n" + c + " " + d;
            }

            public static matrix operator +(matrix obj1, matrix obj2)
            {
                matrix obj = new matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
                return obj;
            }
            public static matrix operator -(matrix obj1, matrix obj2)
            {
                matrix obj = new matrix(obj1.a - obj2.a, obj1.b - obj2.b, obj1.c - obj2.c, obj1.d - obj2.d);
                return obj;
            }
        }
        




        static void Main(string[] args)
        {
           matrix m1 = new matrix(1, 2, 3, 4);
           matrix m2 = new matrix(5, 6, 7, 8);
           matrix m3 = m1 + m2;
            matrix m4 = m1 - m3;

            Console.WriteLine("Matrix 1: \n" + m1);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Matrix 2: \n" + m2);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Matrix 3: \n" + m3);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Matrix 4: \n" + m4);

            Console.ReadLine();        
        }
    }
}

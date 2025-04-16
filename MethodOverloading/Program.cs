using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        public void add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
        public void add(string a, string b)
        {
            string c = a + " " + b;
            Console.WriteLine(c);
        }
        public void add(float a, float b)
        {
            float c = a + b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.add(2.4f,2.5f);
            p.add(10, 5);
            p.add("uday", "mistry");

            Console.ReadLine();
        }

        
    }
}

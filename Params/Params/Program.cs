using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Program
    {
        //public static int add(params int[] nums)
        //{
        //    int sum = 0; 
        //    foreach(int i in nums)
        //    {
        //        sum += i;
        //    }

        //    return sum;
        //}

        public static int add(params int[] num)
        {
            int sum = 0;
            foreach(int i in num)
            {
                sum = sum + i;
            }
            return sum;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine(Program.add(10,20,30,40,20));

            Console.ReadLine();
        }
    }
}

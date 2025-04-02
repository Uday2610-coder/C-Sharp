using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopingStatement
{
    internal class loopingstatement
    {
        static void Main(string[] args)
        {
            //  While Loop
            //if condition false than you don't get output once time

            int i = 1;
            while (i <= 20)
            {
                System.Console.WriteLine(i);
                i++;
            }

            //do while loop
            //if condition false than you get output once time

            int j = 1;
            do
            {
                System.Console.WriteLine(j+" ");
                j++;
            }
            while (j <= 20);

            //for loop

            for(int k =1; k<=20; k++)
            {
                System.Console.Write(k+" ");
            }

            // foreach loop

            int[] b = { 1, 2, 3, 4, 5 };

            foreach(int c in b )
            {
                System.Console.WriteLine(c);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
   
    

        internal class typecasting
        {
            static void Main(string[] args)
            {
            //Implicit Type Casting(Coercion):

            int num_int = 10;
            double num_double = num_int;  

            System.Console.WriteLine(num_double);

            //Explicit Type Casting(Casting):

               double pi = 3.14159;
               int approx_pi = (int)pi;  

               int number = 123;
               String str = Integer.toString(number);  
        }
    }

    
}

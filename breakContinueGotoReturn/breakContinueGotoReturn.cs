using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionStatement
{
    internal class conditionStatement
    {
      static int add(int x, int y)
    {
       return x + y; 
    }
        static void Main(string[] args)
        {
          // break statement
        for(int i = 1; i<=10; i++)
        {
            if(i == 6)
            {
                break;
            }
            Console.WriteLine(i+" ");
        }
        
        //continue statement
        for(int j = 1; j <= 10; j++)
        {
            if(j == 5 || j == 7)
            {
                continue;
            }
            Console.WriteLine(j+" ");
        }
      
        // return statement
        int r = add(10,30);
        Console.WriteLine(r);
        
        // goto statement
        int k = 1;
        go:
        if(k <= 100)
        {
            Console.WriteLine(k+" ");
            k++;
            goto go;
        }
            
        }
    }
}

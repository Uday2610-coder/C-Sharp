using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    //consuming member of a class from non child class of different project
    class Five
    {
        static void Main()
        {
            AccessSpecifiers.Program p = new AccessSpecifiers.Program();
            //p.test1(); // This will not work because test1 is private
          // p.test2(); // This will not work because test2 is internal
            // p.test3(); // This will not work because test3 is protected
           // p.test4(); // This will not work because test4 is protected internal
            p.test5(); // This will work because test5 is public

            Console.ReadLine();
        }
    }
}
 
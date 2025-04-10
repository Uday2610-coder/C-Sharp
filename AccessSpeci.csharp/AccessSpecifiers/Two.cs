using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    //consuming member of a class from child class
    internal class Two:Program
    {
        static void Main()
        {
            Two t = new Two();
            t.test1(); // This will not work because test1 is private
            t.test2(); // This will work because test2 is internal
            t.test3(); // This will  work because test3 is protected
            t.test4(); // This will work because test4 is protected internal
            t.test5(); // This will work because test5 is public
            Console.ReadLine();
        }
    }
}

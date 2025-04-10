using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{ //consuming member of a class from child class of different project
     class Four:AccessSpecifiers.Program
    {
        static void Main(string[] args)
        {
            Four f = new Four();
            //f.test1(); // This will not work because test1 is private
            //f.test2(); // This will not work because test2 is internal
            f.test3(); // This will  work because test3 is protected
            f.test4(); // This will work because test4 is protected internal
            f.test5(); // This will work because test5 is public
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userinput
{
    internal class userinput
    {
        static void Main(string[] args)
        {
            // Taking user input

            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + name);

            //taking user input using typecasting

             Console.WriteLine("How many candies do you want?");
             string can = Console.ReadLine();
             Console.WriteLine("You Will get 4 more candies "+ (Convert.ToInt32(can) + 4 ));
        }
    }
}

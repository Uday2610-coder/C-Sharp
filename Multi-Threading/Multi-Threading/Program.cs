using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi_Threading
{
    internal class Program
    {
        public static void func1()
        {
            for(int i = 1; i<= 50; i++)
            {
                Console.WriteLine("func1: " + i);
            }
        }
        public static void func2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("func2: " + i);
                if (i == 25)
                {
                    Console.WriteLine("Thread is going to sleep for 8 secong...");
                    Thread .Sleep(8000); // Sleep for 1 second
                }
            }

        }
        public static void func3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("func3: " + i);
            }
        }
        static void Main(string[] args)
        {

            // Thread is a class in the System.Threading namespace
            //current thread is the main thread or the thread that is executing the Main method
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("Current Thread: " + Thread.CurrentThread.Name);

            Console.WriteLine("===========================================================");

            // single thread
            Program.func1();
            Program.func2();
            Program.func3();

            // multi-threading
            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);

            //start the threads
            t1.Start();
           
            t2.Start();
           
            t3.Start();

            Console.ReadLine();
        }
    }
}

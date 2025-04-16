using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum Day
    {
        Sunday = 1, //1
        Monday, //2
        Tuesday,//3
        Wednesday, //4 
        Thursday, //5
        Friday, //6
        Saturday //7
    }


    internal class Program
    {
       
        static void Main(string[] args)
        {
            // in built enum
           // Console.BackgroundColor = ConsoleColor.White; // for background color
            Console.ForegroundColor = ConsoleColor.White; // for font color
            //Console.WriteLine("Hello World!");

            Console.WriteLine(Day.Saturday);
            Day Birthday = Day.Friday;
            Console.WriteLine("BirthDay is: "+Birthday);
            Console.WriteLine(Day.Monday );
            Console.WriteLine("----------------------------------------------------");

            //explicit type casting
            Day myDay = (Day)1; // convert integer into enum 
            Console.WriteLine("myDay 1 = "+ myDay);
            Console.WriteLine("----------------------------------------------------");
            int value = (int)Day.Saturday; // convert enum into int
            Console.WriteLine("value of saturday is: "+value);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(myDay);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your day sunday = 1, Monday = 2, Tuesday = 3");

            int value2 = Convert.ToInt32(Console.ReadLine());

            Day myday = (Day)value2;
            Console.WriteLine("My name is: " + name + " and My Birth Day is:  " + myDay);
            Console.WriteLine("----------------------------------------------------");

            //Enum member store in array and print using foreach loop
            //string[] members = (string[])Enum.GetNames(typeof(Day));

            //foreach(string i in members)
            //{
            //    Console.WriteLine(i);
            //}

            //Enum value store in array and print using foreach loop
            //int[] values = (int[])Enum.GetValues(typeof(Day));

            //foreach (int i in values)
            //{
            //    Console.WriteLine(i);
            //}

            // Using Member
            Day MyDay = Day.Wednesday;

            switch (MyDay)
            {
                case Day.Sunday:
                    Console.WriteLine("Hello This is Sunday");
                    break;
                case Day.Monday:
                    Console.WriteLine("Hello This is Monday");
                    break;
                case Day.Tuesday:
                    Console.WriteLine("Hello This is Tuesday");
                    break;
                case Day.Wednesday:
                    Console.WriteLine("Hello This is Wednesday");
                    break;
                case Day.Thursday:
                    Console.WriteLine("Hello This is Thursday");
                    break;
                case Day.Friday:
                    Console.WriteLine("Hello This is Friday");
                    break;
                case Day.Saturday:
                    Console.WriteLine("Hello This is Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Day!!");
                    break;
            }

            Console.WriteLine("----------------------------------------------------");

            // using value
            int MyDay1 = (int)Day.Wednesday;

            switch (MyDay1)
            {
                case 1:
                    Console.WriteLine("Hello This is Sunday");
                    break;
                case 2:
                    Console.WriteLine("Hello This is Monday");
                    break;
                case 3:
                    Console.WriteLine("Hello This is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Hello This is Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Hello This is Thursday");
                    break;
                case 6:
                    Console.WriteLine("Hello This is Friday");
                    break;
                case 7:
                    Console.WriteLine("Hello This is Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Day!!");
                    break;
            }

            Console.ReadLine();
        }
    }
}

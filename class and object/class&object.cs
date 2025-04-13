using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_and_object;

namespace class_and_object
{

   
        // class and object with non static method
        public class student
        {
            public int id;
            public string name;
            public string city;

            //void method
            public void Display()
            {
                Console.WriteLine("Hello Student Fill Information");
            }
            //void parameterized method
            public void setInfo(int id)
            {
                this.id = id;
            }

            // return type method
            public string getInfoId()
            {
                return "student id is" + id;
            }
           // return type parameterized method
            public string getInfoName(string name)
            {
                return "student name is" + name;
            }
        }

        // class and object with static method
        public class Employee
        {
            public static int id;
            public static int salary;
            //static void method
            public static void Display()
            {
                Console.WriteLine("Hello Employee Fill Information");
            }
            //static void parameterized method
            public static void setInfo(int id)
            {
                Employee.id = id;
            }
            //static return type method
            public static string getInfoId()
            {
                return "Employee id is" + id;
            }
            //static return type parameterized method
            public static string getInfoSalary(int salary)
            {
                Employee.salary = salary;
                return "Employee salary is" + salary;
            }
        }
    internal class class_object
    {
        static void Main(string[] args)
        {
            // object of non static method
            Console.WriteLine("------------------------------------------------------");
            student s1 = new student();
            s1.id = 1; //using non static variable objectname.variable
            s1.name = "Uday";
            s1.Display();// void method
            s1.setInfo(1);// void parameterized method
            Console.WriteLine(s1.getInfoId()); // return type method
            Console.WriteLine(s1.getInfoName("Uday")); // return type parameterized method
            Console.WriteLine("------------------------------------------------------");

            //  static method's no need to creare object/instance, directly use with className.MethodName
            Employee.id = 1; // using static variable classname.variable
            Console.WriteLine("Employee id is: " + Employee.id); // using static variable class.variable
            Employee.Display(); // static void method
            Employee.setInfo(1); // static void parameterized method
            Console.WriteLine(Employee.getInfoId()); // static return type method
            Console.WriteLine(Employee.getInfoSalary(10000)); // static return type parameterized method
            Console.WriteLine("------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
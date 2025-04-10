using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class student
    {
        int age;
        int id;
        int rollno;
        // default constructor
        public student()
        { 
            age = 1;
            id = 1;
            rollno = 1;
        }
        // parameterized constructor
        public student(int age, int id, int rollno)
        {
            this.age = age;
            this.id = id;
            this.rollno = rollno;
        }

        public void setInfo(int age, int id, int rollno)
        {
            this.age = age;
            this.id = id;
            this.rollno = rollno;
        }
        public void getInfo()
        {
            Console.WriteLine("age is: {0}", age);
            Console.WriteLine("id is: {0}", id);
            Console.WriteLine("rollno is: {0}", rollno);
        }
    }


    class getset()
    {
        int age;
        int id;
        int rollno;

        public int age { get; set; }
        public int id { get; set; }
        public int rollno { get; set; }
        public getset(int age, int id, int rollno)
        {
            this.age = age;
            this.id = id;
            this.rollno = rollno;
        }
        public void getInfo()
        {
            Console.WriteLine("age is: {0}", age);
            Console.WriteLine("id is: {0}", id);
            Console.WriteLine("rollno is: {0}", rollno);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {

            student s1 = new student();
            s1.setInfo(20, 30, 10);
            s1.getInfo();


            // calling parameterized constructor
            student s2 = new student(25, 35, 20);
            s2.getInfo();

            // calling default constructor
            student s3 = new student();
            s3.getInfo();

            // calling getset class
            getset s4 = new getset;
            s4.age = 20;
            s4.getInfo(age);

            Console.ReadLine();


        }
    }
}

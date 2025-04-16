using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constructor;

namespace Constructor
{
    public class Student
    {
        string name;
        int age;

        public Student()
        {
            name = "Uday";
            age = 23;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Default Constructor Called");
        }

         public Student(string name, int age)
         {
            this.name = name;
            this.age = age;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Parameterized Constructor Called");
        }
    }
    //Default constructor and parameterized constructor
    public class B
    {
       int x;

        static B() // static constructor
        {
            Console.WriteLine("Static Constructor B Called");
        }

        public B() // default constructor
        {
            x = 0;
            Console.WriteLine("Default Constructor B Called : ");
        }
        public B(int i) // Perameterized Constructor
        {
            x = i;
            Console.WriteLine("perameterized Constructor B Called & value of i is: " + i);
        }
        public void Display()
        {
            Console.WriteLine("value of x is: " + x);
        }
    }

    

    class student
    {
        string name;
        int id;
        int age;

       static int std;

        static student()
        {
            std = 12;
            Console.WriteLine("This is 12th class Info");
        }

        public student()
        {
            name = "NaN";
            id = 0;
            age = 0;
            Console.WriteLine("Please fill all Info");
        }

        public void setInfo(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
        public void getInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Age: " + age);
        }


    }

    public class A
    {
        static int i;
        static A()
        {
            i = 10;
            Console.WriteLine("Static Constructor A Called " + i);
        }

        public A()
        {
            Console.WriteLine("Default Constructor A Called " + i);
        }

        public A(int i)
        {
            Console.WriteLine("Parameterized Constructor A Called " + i);
        }

    }










    internal class Program
    {
        static void Main(string[] args)
        {
            // default and perameterized constructor
            Student s1 = new Student();
            Console.WriteLine("----------------------------------------------");
            Student s2 = new Student("John", 25);
            Console.WriteLine("----------------------------------------------");
            Student s3 = new Student();
            Console.WriteLine("----------------------------------------------");
            Student s4 = new Student("Doe", 30);
            Console.WriteLine("----------------------------------------------");
            
            B c = new B(10); // parameterized constructor
            c.Display();// display method x = i; , default constructor
            B d = new B(20); // parameterized constructor
            d.Display(); // display method x = i; , default constructor
            Console.WriteLine("-----------------------------------------------");
            B b = new B(); // calling static and non - static constructor
            B b1 = new B(); // calling non static constructor
            B b2 = new B(); // calling non static constructor
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
            student s = new student();
            s.setInfo("Uday", 1, 23);
            s.getInfo();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");

            A a = new A();
            A a1 = new A(20);


            Console.ReadLine();
        }
    }
}
 
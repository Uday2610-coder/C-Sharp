using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class Person // abstract class
    {
        public string FirstName;
        public string LirstName;
        public int Age;
        public long PhoneNumber;

        public abstract void PrintDetails(); // abstract method
        
    }
    class Student : Person
    {
        public int RollNo;
        public int Fees;

        public override void PrintDetails() // body of abstract method 
        {
            string name = this.FirstName + " " + this.LirstName;
            Console.WriteLine("Student Name is: {0}", name);
            Console.WriteLine("Student age is: {0}", this.Age);
            Console.WriteLine("Student PhoneNumber is: {0}", this.PhoneNumber);
            Console.WriteLine("Student RollNo is: {0}", this.RollNo);
            Console.WriteLine("Student Fees is: {0}", this.Fees);
            
        }
    }
    class Teacher : Person
    {
        public string Qualification;
        public int Salary;
        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LirstName;
            Console.WriteLine("Teacher Name is: {0}", name);
            Console.WriteLine("Teacher age is: {0}", this.Age);
            Console.WriteLine("Teacher PhoneNumber is: {0}", this.PhoneNumber);
            Console.WriteLine("Teacher Qualification is: {0}", this.Qualification);
            Console.WriteLine("Teacher Salary is: {0}", this.Salary);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.FirstName = "Uday";
            s1.LirstName = "Mistry";
            s1.Age = 23;
            s1.PhoneNumber = 3245688767;
            s1.RollNo = 243;
            s1.Fees = 10000;
            s1.PrintDetails();

            Console.WriteLine("---------------------------------------------------------------------");

            Teacher t1 = new Teacher();
            t1.FirstName = "Shailesh";
            t1.LirstName = "Mistry";
            t1.Age = 43;
            t1.PhoneNumber = 6578656785;
            t1.Salary = 32000;
            t1.Qualification = "Master in Computer Science";
            t1.PrintDetails();

            Console.ReadLine();
            
        }
    }
}

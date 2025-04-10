using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_and_object;

namespace class_and_object
{
    //    class Student
    //    {
    //        int rollno;
    //        String name;
    //        int age;
    //        int standard;

    //        public void setStudent(int rollno, String name, int age, int standerd)
    //        {
    //            this.rollno = rollno;
    //            this.name = name;
    //            this.age = age;
    //            this.standard = standerd;
    //        }
    //        public void getStudent()
    //        {
    //            Console.WriteLine("Your rollno is: {0}", this.rollno);
    //            Console.WriteLine("Your name is: {0}", this.name);
    //            Console.WriteLine("Your age is: {0}", this.age);
    //            Console.WriteLine("Your class is: {0}", this.standard);
    //        }
    //    }

    //class sum
    //{
    //    int x;
    //    int y;

    //    public int add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //}

    //class Information
    //{
    //    String name;
    //    int age;
    //    String city;
    //    String country;

    //    public void getInf0rmation(String name, int age, String city, String country)
    //    {
    //        this.name = name;
    //        this.age = age;
    //        this.city = city;
    //        this.country = country;

    //    }

    //    public void displayInformation()
    //    {
    //        Console.WriteLine("Your name is: {0}", name);
    //        Console.WriteLine("Your age is: {0}", age);
    //        Console.WriteLine("Your city is: {0}", city);
    //        Console.WriteLine("Your country is: {0}", country);
    //    }
    //}
    //class Rectangle
    //{
    //        int length;
    //        int width;

    //        public void GetData(int x, int y)
    //        {
    //            length = x;
    //            width = y;
    //        }
    //        public int Area()
    //        {
    //            return(length * width);
    //        }
    //}

    //class myInformation
    //{
    //    string name;
    //    int birthyear;
    //    int age;
    //    string city;

    //    public void setInformation(string name, int birthyear, string city)
    //    {
    //        this.name = name;
    //        this.birthyear = birthyear;
    //        this.age = 2025 - birthyear;
    //        this.city = city;
    //    }

    //    public void getInformation()
    //    {
    //        Console.WriteLine("Your name is: {0}", name);
    //        Console.WriteLine("Your birthyear is: {0}", birthyear);
    //        Console.WriteLine("Your age is: {0}", age);
    //        Console.WriteLine("Your city is: {0}", city);
    //    }
    //class Sum
    //{
    //    int a;
    //    int b;

    //    public int add(int a, int b)
    //    {
    //        return a + b;
    //    }
    //}


    class Intern
    {
        int enrollmentNo;
        String name;
        int age;
        String specialization;
        int yearOfJoining;
        String city;
        String collegeName;

        public void setIntern(int enrollmentNo, String name, int age, String specialization, int yearOfJoining, String city, String collegeName )
        {
            this.enrollmentNo = enrollmentNo;
            this.name = name;
            this.age = age;
            this.specialization = specialization;
            this.yearOfJoining = yearOfJoining;
            this.city = city;
        }

        public void getIntern()
        {
            Console.WriteLine("Enter your enrollment number: ");
            Console.WriteLine("Enter your name: ");
            Console.WriteLine("Enter your age: ");
            Console.WriteLine("Enter your specialization: ");
            Console.WriteLine("Enter your year of joining: ");
            Console.WriteLine("Enter your city: ");
            Console.WriteLine("Enter your college name: ");

            enrollmentNo = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            specialization = Console.ReadLine();
            yearOfJoining = Convert.ToInt32(Console.ReadLine());
            city = Console.ReadLine();
            collegeName = Console.ReadLine();

            Console.WriteLine("Your enrollment number is: {0}", this.enrollmentNo);
            Console.WriteLine("Your name is: {0}", this.name);
            Console.WriteLine("Your age is: {0}", this.age);
            Console.WriteLine("Your specialization is: {0}", this.specialization);
            Console.WriteLine("Your year of joining is: {0}", this.yearOfJoining);
            Console.WriteLine("Your city is: {0}", this.city);
            Console.WriteLine("Your college name is: {0}", this.collegeName);





        }
    }

}


internal class class_object
    {
        static void Main(string[] args)
        {



        //Student uday = new Student();
        //uday.setStudent(11, "Uday", 23, 12);

        //Student dev = new Student();
        //dev.setStudent(12, "dev", 20, 10);

        //uday.getStudent();
        //dev.getStudent();


        //sum s1 = new sum();
        //int result = s1.add(10, 20);
        //Console.WriteLine("The sum of 10 and 20 is: {0}", result);  

        //Information Uday = new Information();
        //Uday.getInf0rmation("Uday", 23, "Pune", "India");
        //Uday.displayInformation();


        //Rectangle rec1 = new Rectangle();
        //rec1.GetData(30, 40);
        //int area = rec1.Area();
        //Console.WriteLine(area);S

        //myInformation uday = new myInformation();
        //uday.setInformation("Uday", 2002, "Bharuch");
        //uday.getInformation();


        //Sum s1 = new Sum();
        //int result = s1.add(10, 20);
        //Console.WriteLine("The sum of 10 and 20 is: {0}", result);

        Intern uday = new Intern();
        uday.getIntern();

        Console.ReadLine();

        }
    }


   


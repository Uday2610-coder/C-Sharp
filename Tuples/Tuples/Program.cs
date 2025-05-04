using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    internal class Program
    {
        //---------tuples as method return type---------

        //public static (string Name, bool isValid) show(string name)
        //{
        //    if(name.Equals("ramesh"))
        //    {
        //        return ("Hello ramesh", true);
        //    }
        //    else
        //    {
        //        return(name, false);
        //    }
        //}

        //----------Deconstruction----------

        //public static (string name, int age, double height) GetStudent()
        //{
        //    return ("suresh", 31, 5.7);
        //}

        //----------Tuples as method perameter----------

        //public static void SetTupleMethod((string Name, int Age) Person)
        //{
        //    Console.WriteLine($"Name is: {Person.Name}, Age is: {Person.Age}");
        //}
        static void Main(string[] args)
        {
            //var student = ("xyz",23,5.11); 
            //Console.WriteLine(student.Item1); //xyz
            //Console.WriteLine(student.Item2); //23
            //Console.WriteLine(student.Item3); //5.11

            //(string, int, double) student = ("xyz", 22, 6.11);
            //Console.WriteLine(student.Item1);
            //Console.WriteLine(student.Item2);
            //Console.WriteLine(student.Item3);

            //----------Named tuple fields---------

            //(string Name, int Age, double Height) student = ("Jhon", 22, 6.11);
            //Console.WriteLine(student.Name);
            //Console.WriteLine(student.Age);
            //Console.WriteLine(student.Height);

            //----------reassign value---------- 

            //student.Age = 29;
            //Console.WriteLine(student.Age);   

            //----------tuple Equality----------

            //(string, int) t1 = ("ramesh", 22);
            //(string, int) t2 = ("suresh", 22);
            //Console.WriteLine(t1 == t2);
            //Console.WriteLine(t2 != t1);

            //----------tuple as method return types----------

            //var student = show("ramesh");
            //if (student.isValid)
            //{
            //    Console.WriteLine($"Message is: {student.Name}");
            //}
            //else
            //{
            //    Console.WriteLine("Who are you");
            //}

            //----------Deconstruction----------

            //(string stdName, int stdAge, double stdHeight) = GetStudent();
            //var(stdName, stdAge, stdHeight) = GetStudent();
            //(string stdName, var stdAge, var stdHeight) = GetStudent();

            //(string stdName, _, _) = GetStudent(); // when you want only one variable
            //Console.WriteLine(stdName);

            //----------Tuples as method perameter----------

            //var myPerson = ("Prem", 24);
            //SetTupleMethod(myPerson); 

            //----------Creating Tuples using Create() Method----------

            //var num = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);  //size of Create() method is 8
            //Console.WriteLine(num.Item4);

            //---------- NESTED TUPLE ----------

            //var num = Tuple.Create(1, 2, 3, 4, 5, Tuple.Create(6, 7, 8, 9, 10));
            //Console.WriteLine(num.Item4); //4
            //Console.WriteLine(num.Item6.Item4); //9

            Console.ReadLine();
        }
    }
}

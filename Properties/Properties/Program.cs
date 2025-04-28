using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    // Properties are used to expose the data members of a class in a controlled way.
    // Properties are used to implement encapsulation in C#.
    // Properties are used to provide a flexible mechanism to read, write or compute the value of a private field.
    // Properties are declared like methods but they are accessed like fields.
    // Properties can be read-only, write-only or read-write.


    // read and write properties
    class Student
    {
        private int _StdId;
        private string _Name;
        private string _Fname;

        public int StdId
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Id can't be Zero or Negative");
                }
                else
                {
                    this._StdId = value;
                }
            }
            get
            {
                return this._StdId;

            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Field is required");
                }
                else
                {
                    this._Name = value;
                }
            }
            get
            {
                return this._Name;

            }
        }
    }

    // Read and Write Properties
    class A
    {
        private int _id;

        public int getset
        {
            set { this._id = value; }
            get { return this._id; }
        }

    }

    //Writeonly property
    class b
    {
        private string _name;

        public string Name
        {
            set { this._name = value; }
        }
    }

    // ReadOnly Properties
    public class Customer
    {
        int _Custid;
        bool Status;
        string Cname;
        double Balance;

        public Customer( int custid, bool Status, string Cname, double Balance)
        {
            this._Custid = custid;
            this.Status = Status;
            this.Cname = Cname;
            this.Balance = Balance;
        }

        public int Custid
        {
            get { return _Custid; }
        }
    }
    // ReadOnly Properties
    public class Student1
    {
        private int _StdId;

        public Student1(int stdId)
        {
            this._StdId = stdId;
        }

        public int StdId
        {
            get { return _StdId; }
        }
    }

    // auto implementation properties
    public class B
    { 
        public string Fname { get; set; }// set is not private means we can modified value
        public string Lname { get; set; }// set is not private means we can modified value

        public B(string fname, string lname)
        {
            Fname = fname;
            Lname = lname;
        }
    }

    public class C
    {
        public string Fname { get; private set; } // set is private means we can't modified value
        public string Lname { get; private set; } // set is private means we can't modified value

        public C(string fname, string lname)
        {
            Fname = fname;
            Lname = lname;
        }
    }

    public class D
    {
        public string name { get; set; } = "Uday"; // auto initialization properties
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // read and write properties
            Student s1 = new Student();
            s1.StdId = 12;
            Console.WriteLine("Student id: " + s1.StdId);
            s1.Name = "Uday";
            Console.WriteLine("Name of student: " + s1.Name);

            Console.WriteLine("----------------------------------------------");

            // Read and Write Properties
            A a = new A();
            a.getset = 12;
            Console.WriteLine(a.getset);

            Console.WriteLine("----------------------------------------------");

            // Writeonly property
            b b1 = new b();
            b1.Name = "Uday";

          

            // ReadOnly Properties
            Customer customer = new Customer(121, true, "Uday", 1200000);
            Console.WriteLine("Customer ID: " + customer.Custid);
      
            Student1 s = new Student1(1212);
            Console.WriteLine("Student id: " + s.StdId);

            Console.WriteLine("----------------------------------------------");

            // auto implementation properties
            B b = new B("Uday", " Mistry");
            Console.WriteLine(b.Fname + b.Lname);

            // modification is allowed because set propertie is not private
            b.Fname = "uday";
            b.Lname = " mistry";
            Console.WriteLine("after modification: "+ b.Fname + b.Lname);

            Console.WriteLine("----------------------------------------------");

            C c = new C("Hello", "World!");
            Console.WriteLine(c.Fname + c.Lname);
            // modification is not allowed because set propertie is private
            //c.Fname = "Uday";
            //c.Lname = " Mistry";
            //Console.WriteLine("after Modified:" + c.Fname + c.Lname);

            Console.WriteLine("----------------------------------------------");

            // auti initialization properties
            D d = new D();
            Console.WriteLine("Modification allowed in Auto initialization:");
            Console.WriteLine("before modification/default value of name: " + d.name);
            d.name = "Mistry";
            Console.WriteLine("after modification value of name: "+d.name);

            Console.ReadLine();

        }

    }

}
 
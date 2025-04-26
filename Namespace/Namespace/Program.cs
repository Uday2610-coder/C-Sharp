using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Namespace 
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student()
        {
            Console.WriteLine("Student class");
        }
    }
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Teacher()
        {
            Console.WriteLine("Teacher class");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}


namespace HostingNamespace // hostings namespace
{
    public class HostingClass
    {
        public void Display()
        {
            Console.WriteLine("Hosting class in HostingNamespace");
        }
    }
    namespace NestedNamespace // nested namespace
    {
        public class NestedClass
        {
            public void Display()
            {
                Console.WriteLine("Nested class in HostingNamespace");
            }
        }
    }

}

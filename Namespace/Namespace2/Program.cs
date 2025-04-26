using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Namespace;    // add another namespace after add a reference to the project  // add another project name space in this project
using StuAlias = Namespace.Student; // using directive with alias
using TeaAlias = Namespace.Teacher; // using directive with alias
using HostingNamespace; // using directive with hosting namespace
using HostingNamespace.NestedNamespace; // using directive with nested namespace
using DLL_Library_; // using directive with DLL


namespace Namespace2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- using fully qualifiedName ----------");
            Console.WriteLine(" ");

            // using directive with fully qualified name
            Namespace.Student s1 = new Namespace.Student(); // fully qualified name
            s1.Id = 1;
            s1.Name = "John Doe";
            Console.WriteLine($"Id: {s1.Id}, Name: {s1.Name}");
            Namespace.Teacher t1 = new Namespace.Teacher(); // fully qualified name
            t1.Id = 1;
            t1.Name = "Jane Smith";
            Console.WriteLine($"Id: {t1.Id}, Name: {t1.Name}");

            Console.WriteLine(" ");
            Console.WriteLine("---------- using Alias ----------");
            Console.WriteLine(" ");

            // using directive with alias
            StuAlias s2 = new StuAlias(); // using directive
            s2.Id = 2;
            s2.Name = "Jane Doe";
            Console.WriteLine($"Id: {s2.Id}, Name: {s2.Name}");

            TeaAlias s3 = new TeaAlias(); // using directive
            s3.Id = 3;
            s3.Name = "John Smith";
            Console.WriteLine($"Id: {s3.Id}, Name: {s3.Name}");

            Console.WriteLine(" ");
            Console.WriteLine("---------- Example of HostingName Space and NestedName Space ----------");
            Console.WriteLine(" ");

            HostingClass h1 = new HostingClass(); // using directive with hosting namespace
            h1.Display();

            NestedClass n1 = new NestedClass(); // using directive with nested namespace
            n1.Display();

            Console.WriteLine(" ");
            Console.WriteLine("---------- Example of DLL ----------");
            Console.WriteLine(" ");

            Class1 c1 = new  Class1(); // using directive with DLL
            c1.Display();

            


            Console.ReadLine();

        }
    }
}

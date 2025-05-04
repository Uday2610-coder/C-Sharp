using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    //if i defined one partial class as a sealed than automatically all partial class maked selaed
    //i can't use sealed class as a parent class
    //public class MyClass : SealedClass // Show Error
    //{
    //}

    //if i inherit one partial class than all partial class inherit automatical 
    class X : InheritanceExample
    {

    }


    internal class Program 
    {
        static void Main(string[] args)
        {
            //Create instance of partial class
            StudentPartial Stu1 = new StudentPartial();

            // using studentPartial1 class
            Stu1.FirstName = "Suresh";
            Stu1.LastName = "Sharma";

            //using studentpartial2 class 
            Console.WriteLine("Your Full Name is: " + Stu1.GetCompleteName());

            Console.WriteLine("-------------------------------------------");

            //create instance of Addition class
            Addition Sum1 = new Addition();
            //using addition1 partial class
            Sum1.SetValue(10, 23);
            // using addition2 partial class
            Sum1.Get();

            
            // example of abstract partial class
            // if i define only one partial class as abstract class all partial class  automatically define as abstract
            //AbstractClassExample Example = new AbstractClassExample();


            //Exapmle of Inheritance in partial class
            X x1 = new X();
            x1.show1();   
            x1.show2();  // diff partial class  

            
           
            Console.ReadLine();

        }
    }
}

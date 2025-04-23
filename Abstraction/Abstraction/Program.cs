using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double TaxDeduction = 0.1;
        double netSalary;

        public Employee(int Eid, string Ename, double Egrosspay)
        {
            this.EmpId = Eid;
            this.EmpName = Ename;
            this.GrossPay = Egrosspay;

        }
        
        void CalculateSalary() // Encapsulation 
        {
            if(GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Your salary is: {0}", netSalary);
            }
            else
            {
                Console.WriteLine("Your salary is: {0}", GrossPay);
            } 
        }

        public void ShowEmployeeDetails() // abstract method
        {
            Console.WriteLine("Employe Name is {0}",EmpName);
            Console.WriteLine("Employe id is {0}", EmpId);
            this.CalculateSalary();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee(101, "Uday", 20000);
            E1.ShowEmployeeDetails(); 
        }
    }
}

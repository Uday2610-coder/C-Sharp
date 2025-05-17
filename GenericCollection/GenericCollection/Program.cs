using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=============================Dictionary=============================
            // value can be null but key can be not null
            // key must be unique

            //Dictionary<string, string> myDict = new Dictionary<string, string>();

            //myDict.Add("name", "Jhon");
            //myDict.Add("add", "Usa");
            //myDict.Add("age", null);

            //foreach (KeyValuePair<string, string> pair in myDict)
            //{
            //    Console.WriteLine(pair.Key + " : " + pair.Value);
            //}

            //foreach(string key in myDict.Keys)
            //{
            //    Console.WriteLine(key);
            //}

            //foreach(string value  in myDict.Values)
            //{
            //    Console.WriteLine(value);
            //}

            //Console.WriteLine(myDict.Count); //return total elements

            //Employee emp1 = new Employee()
            //{
            //    Id = 111,
            //    name = "Jhon",
            //    designation = "Manager",
            //    salary = 36000
            //};

            //Employee emp2 = new Employee()
            //{
            //    Id = 222,
            //    name = "Dev",
            //    designation = "Assistant",
            //    salary = 16000
            //};

            //Employee emp3 = new Employee()
            //{
            //    Id = 333,
            //    name = "Alice",
            //    designation = "Operator",
            //    salary = 13000
            //};

            //Dictionary<int, Employee> myEmployee = new Dictionary<int, Employee>();

            //myEmployee.Add(emp1.Id, emp1);
            //myEmployee.Add(emp2.Id, emp2);
            //myEmployee.Add(emp3.Id, emp3);

            //Console.WriteLine(myEmployee.Count(emp => emp.Value.salary > 15000));
            //Console.WriteLine(myEmployee.Count(emp => emp.Value.name.StartsWith("A")));

            //myDict.Remove("name"); //remove the element with the specified key

            //foreach (KeyValuePair<string, string> pair in myDict)
            //{
            //    Console.WriteLine(pair.Key + " : " + pair.Value);
            //}

            //Console.WriteLine(myDict.ContainsKey("name")); //return bool value

            //Console.WriteLine(myDict.ContainsValue("Jhon")); //return bool value

            //myDict.Clear(); //remove all elements

            //foreach (KeyValuePair<string, string> pair in myDict)
            //{
            //    Console.WriteLine(pair.Key + " : " + pair.Value);
            //}

            //string value;
            //myDict.TryGetValue("name", out value ); // if name key is available than passing name value in value string and return bool value
            //Console.WriteLine(value);



            //================================= List ======================================
            // null as a valid value for refrence and duplicate also allows

            //List<int> L1 = new List<int>();

            //L1.Add(10);
            //L1.Add(9);
            //L1.Add(11);
            //L1.Add(13);
            //L1.Add(12);

            //foreach (int i in L1)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("----------------------------");

            //L1.Reverse(); // reverse order of element

            //foreach (int i in L1)
            //{
            //    Console.WriteLine(i);
            //}



            //Console.WriteLine(L1.IndexOf(13)); //return index of specified element

            //Console.WriteLine(L1.IndexOf(12 , 2)); // it's start searching after specified index

            //L1.Clear(); //remove all elements

            //Console.WriteLine(L1.Contains(10)); // return bool value


            //Console.WriteLine("after sort elements");
            //L1.Sort();

            //foreach (int i in L1)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(L1.Capacity); // total number of elements the internal data structure can hold

            //Console.WriteLine(L1.Count); //get the number of element cantained in the list

            //L1.AddRange(L1); //add element of the specified collection

            //foreach (int i in L1)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("---------------------------------");

            //L1.Insert(3, 14); //add one element into the list<t> at the specified index
            //foreach(int i in L1)
            //{ 
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("---------------------------------");

            //L1.InsertRange(2, L1); //add multiple alement 

            //foreach(int i in L1)
            //{ 
            //    Console.WriteLine(i); 
            //}

            //Console.WriteLine("---------------------------------");

            //L1.Remove(10); // remove element 10

            //foreach(int i in L1)
            //{ 
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("---------------------------------");

            //L1.RemoveAt(3); // remove element at the specified index

            //foreach (int i in L1)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("---------------------------------");

            //L1.RemoveRange(2, 2); // index , how many element want you remove 

            //foreach (int i in L1)
            //{
            //    Console.WriteLine(i);
            //}



            //List<string> L2 = new List<string>();

            //L2.Add("Abc");
            //L2.Add(null);
            //L2.Add("ABC");

            //foreach (string i in L2)
            //{
            //    Console.WriteLine(i);
            //}



            //Employee emp1 = new Employee()
            //{
            //    name = "Jhon",
            //    designation = "Manager",
            //    age = 24
            //};

            //Employee emp2 = new Employee()
            //{
            //    name = "Dev",
            //    designation = "Assistant",
            //    age = 28
            //};

            //Employee emp3 = new Employee()
            //{
            //    name = "Alice",
            //    designation = "Operator",
            //    age = 25
            //};

            //List<Employee> emp = new List<Employee>();

            //emp.Add(emp1);
            //emp.Add(emp2);
            //emp.Add(emp3);

            //Employee e = emp.Find(em => em.age > 24);
            //Employee e = emp.FindLast(em => em.age > 24);
            //Console.WriteLine("EmployeeName is: " + e.name + " Employee designation is: " + e.designation + " Employee age is: " + e.age);
            //List<Employee> emps = emp.FindAll(em => em.age > 24);
            //Console.WriteLine("EmployeeName is: " + emps.name + " Employee designation is: " + emps.designation + " Employee age is: " + e.age);



            //Console.WriteLine(emp.Exists(em => em.name.StartsWith("A"))); // return bool value

            //foreach (Employee employee in emp)
            //{
            //    Console.WriteLine("EmployeeName is: " + employee.name + " Employee designation is: " + employee.designation + " Employee age is: " + employee.age);

            //}

            //Console.WriteLine("-------------------------------------");

            //emp.RemoveAll(em => em.age > 24);


            //foreach (Employee employee in emp)
            //{
            //    Console.WriteLine("EmployeeName is: " + employee.name + " Employee designation is: " + employee.designation + " Employee age is: " + employee.age);

            //}




            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //===========================ArrayList================================


            //ArrayList MyList = new ArrayList();
            //Console.WriteLine(MyList.Capacity); //0

            //MyList.Add(10);
            //MyList.Add(20);
            //MyList.Add(30);

            //Console.WriteLine(MyList.Capacity); //4
            //MyList.Add(40);
            //MyList.Add(50);
            //Console.WriteLine(MyList.Capacity); //8

            //foreach(int i in MyList)
            //{
            //    Console.WriteLine(i + " ");
            //}

            //MyList.Insert(2, 25); // Add Value

            //foreach (int i in MyList)
            //{
            //    Console.WriteLine(i + " ");
            //}

            //MyList.Remove(25); // Direct 25 Value Remove

            //foreach (int i in MyList)
            //{
            //    Console.WriteLine(i + " ");
            //}

            //MyList.RemoveAt(3); //Remove At Index 3 valueb  

            //foreach (int i in MyList)
            //{
            //    Console.WriteLine(i + " ");
            //}

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(10);
            //arrayList.Add("Xyz");
            //arrayList.Add('A');
            //arrayList.Add(true);
            //foreach(object obj in arrayList)
            //{
            //    Console.Write(obj + " ");
            //}

            //===========================HashTable================================ 

            //Hashtable ht = new Hashtable()
            //{
            //    { "ID", 101 },
            //    { "Name", "Jhon" },
            //    { "Salary", 30000.00},
            //    { "Department", "Manager" },
            //    { "isMarried", false}
            //};

            //Hashtable ht = new Hashtable();
            //ht.Add("ID",101);
            //ht.Add("Name", "Jhon");
            //ht.Add("Salary", 30000.00);
            //ht.Add("Department", "Manager");
            //ht.Add("isMarried", false);

            //Console.WriteLine(ht["Department"]); //accessing value using key

            // for printing key 

            // foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(key);
            //}

            // for printing value

            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(ht[key]);
            //}

            //printing key and value

            //foreach(object key in ht.Keys)
            //{
            //    Console.WriteLine(key + " : " + ht[key]);
            //}

            //remove element
            // ht.Remove("Salary");

            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(key + " : " + ht[key]);
            //}

            // ht.Clear(); // clear HashTable

            //Console.WriteLine(ht.Contains("Name")) ; //use for check hashtable contain specific key or not
            //Console.WriteLine(ht.ContainsKey("Age")); //also use for check hashtable contain specific key or not

            //Console.WriteLine(ht.ContainsValue(101)); //use for check hashtable contain specific value or not

            // Console.WriteLine("Jhon ".GetHashCode());  // return the hashcode for the specified value

            //Console.WriteLine(ht.Count);// return total count of key/value


            //============================Stack=================================
            // Last-in-First-out
            // Stack aslo allows null and duplicate values

            //Stack myStack = new Stack();

            //myStack.Push("Xyx"); //7th
            //myStack.Push(22); //6th
            //myStack.Push(5.5); //5th
            //myStack.Push(null); //4th
            //myStack.Push(false); //3rd
            //myStack.Push("abc"); //2sec
            //myStack.Push("abc"); //1st

            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(myStack.Count);   //return total number of element

            //Console.WriteLine(myStack.Peek());  // return first value of stack

            //Console.WriteLine(myStack.Pop()); // remove 1st element and return items from top of the stack

            //myStack.Pop(); //remove top element of stack

            //Console.WriteLine("---------------------------------------------");

            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(myStack.Contains(22));  // return bool value 

            //myStack.Clear(); //remove all element 

            //foreach (var item in myStack)
            //{
            //    Console.WriteLine(item);
            //}

            //============================Queue=================================
            // FIFO(First in First out)
            // Stack aslo allows null and duplicate values


            //Queue myQueue = new Queue();

            //myQueue.Enqueue("Xyz");
            //myQueue.Enqueue(22);
            //myQueue.Enqueue(5.5);
            //myQueue.Enqueue(null);
            //myQueue.Enqueue(false);
            //myQueue.Enqueue('X');
            //myQueue.Enqueue('X');
            //myQueue.Enqueue("ABC");

            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine(item);
            //}

            ////Console.WriteLine(myQueue.Count); //return total number of element 

            //Console.WriteLine("---------------------------------------------");

            //myQueue.Dequeue();  // remove 1st element of queue 

            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(myQueue.Peek()); //return 1st item of queue

            //Console.WriteLine(myQueue.Contains(null));   // return bool value 
           
            //myQueue.Clear();  //remove all element 

            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadLine();
        }
    }
}

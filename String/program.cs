using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //string builder class
using System.Diagnostics;// for debugging
using System.Threading.Tasks;

namespace String
{
    internal class program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";
            Console.WriteLine(str);
            Console.WriteLine(str[0]); // First character
            Console.WriteLine(str.Length); // Length of the string
            Console.WriteLine(str.ToUpper()); // Convert to uppercase
            Console.WriteLine(str.ToLower()); // Convert to lowercase
            Console.WriteLine(str.Contains("World")); // Check if it contains "World"
            Console.WriteLine(str.IndexOf("World")); // Find the index of "World"

            // strings are immutable
            string str2 = "Hello";
            Console.WriteLine(str2);
            Console.WriteLine(str.Equals(str2));// compare two strings
            Console.WriteLine(str + " " + str2); // Concatenate strings

            //string interpolation using $
            Console.WriteLine($"String 1: {str}, String 2: {str2}"); // String interpolation
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine(); // Read a string from the console
            Console.WriteLine("Enter your birthdate: ");
            string birthdate = Console.ReadLine(); // Read another string from the console
            Console.WriteLine($"Name: {name}, Birthdate: {birthdate}"); // Print the strings

            // @ symbol for verbatim string literal
            string path = @"C:\Users\Name\Documents\File.txt"; // Verbatim string

            //string builder is mutable
            StringBuilder Uday = new StringBuilder("good");
            Uday.Append(" morning"); // Append to the string
            Console.WriteLine(Uday); // Print the string
            Uday.Append(" to you");
            Console.WriteLine(Uday); // Print the string

            //example of string  and immutability
            string s1 = "Uday";
            Stopwatch sw1 = new Stopwatch();
            sw1.Start(); // Start the stopwatch
            for (int i=0; i<100000; i++)
            {
                s1 = s1 + i;
            }
            sw1.Stop(); // Stop the stopwatch

            //example of string builder and mutability
            string s2 = "Uday";
            Stopwatch sw2 = new Stopwatch();
            sw2.Start(); // Start the stopwatch
            for ( int i = 0; i < 100000; i++)
            {
                s2 = s2 + i;
            }
            sw2.Stop();// Stop the stopwatch
            Console.WriteLine("Time taken by string: ",sw1.ElapsedMilliseconds );
            Console.WriteLine("Time taken by string builder: ",sw2.ElapsedMilliseconds);

            Console.ReadLine();




        }
    }
}

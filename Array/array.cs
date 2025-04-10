 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class array
    {
        static void Main(string[] args)
        {

            /* Array - is a collection of element of a single data
            type & is a collection of releted values*/


            //array with size provided
            int[] myArray = new int[4];

            // how to allocate value
            myArray[0] = 11;
            myArray[1] = 22;
            myArray[2] = 33;
            myArray[3] = 44;

            //how to access value using index

            Console.WriteLine(myArray[0]);
            Console.WriteLine(myArray[1]);
            Console.WriteLine(myArray[2]);
            Console.WriteLine(myArray[3]);

            // array without size provided 

            string[] Uday = new string[] { "Uday", "Mistry", "s." };
            Console.WriteLine(Uday[0]);
            Console.WriteLine(Uday[1]);
            Console.WriteLine(Uday[2]);

            string[] arr = { "hello", "good", "morning" };
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);

            // find array of length
            Console.WriteLine(myArray.Length);
            Console.WriteLine(Uday.Length);
            Console.WriteLine(arr.Length);

            int[] numbers = new int[4] { 10, 20, 30, 40 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach (int i in numbers)
            {
                Console.WriteLine(i);

            }

            // 2d array [2,3] means 2 rows and 3 columns
            int[,] twoDArray = new int[2, 3];

            
            for(int i = 0; i < 2; i++) // row
            {
                for (int j = 0; j < 3; j++) // column
                {
                   twoDArray[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            //print 2d array
            for (int i = 0; i < 2; i++) // row
            {
                for (int j = 0; j < 3; j++) // column
                {
                    Console.Write(twoDArray[i, j]+" ");
                }
               
            }

            //int[,] twoDArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            Console.WriteLine(twoDArray[0, 0]);
            Console.WriteLine(twoDArray[0, 1]);
            Console.WriteLine(twoDArray[0, 2]);


            twoDArray[0, 0] = 100;
            Console.WriteLine(twoDArray[0, 0]);



            //3d array [2,2,2] means 2 rows, 2 columns and 2 depth
            int[,,] threeDArray = new int[2, 2, 2];
            for (int i = 0; i < 2; i++) // row
            {
                for (int j = 0; j < 2; j++) // column
                {
                    for (int k = 0; k < 2; k++)
                    {
                        threeDArray[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            //print 3d array
            for (int i = 0; i < 2; i++) // row
            {
                for (int j = 0; j < 2; j++) // column
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write(threeDArray[i, j, k] + " ");
                    }
                }
            }



            Console.ReadLine();


        }
    }
}

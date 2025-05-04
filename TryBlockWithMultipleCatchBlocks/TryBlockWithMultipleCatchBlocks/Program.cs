using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBlockWithMultipleCatchBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                int result = num / 0;
                Console.WriteLine("Result is: " + result);

            }
            catch(FormatException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

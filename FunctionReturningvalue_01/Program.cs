using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionReturningvalue_01
{
    //returning type function
    internal class Program
    {
        //function creating
        public static int addition()
        {
            int first , second ;
            Console.Write("\nEnter the first number:\t");
            first = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the second number:\t");
            second = int.Parse(Console.ReadLine());
            int sum = first + second;
            return sum;
        }
        static void Main(string[] args)
        {
           int x = addition();
            Console.WriteLine($"The sum of numbers is {x}");
            Console.ReadLine();
        }
    }
}

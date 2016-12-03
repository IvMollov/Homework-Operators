using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._1_Odd_Or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Enter number: ");
         int number = int.Parse(Console.ReadLine());
         if (number % 2 == 0)
         {
           Console.Write("Number {0} is even.", number);
         }
         else
         {
           Console.Write("Number {0} is odd.", number);
         }
            Console.ReadLine();
        }
    }
}

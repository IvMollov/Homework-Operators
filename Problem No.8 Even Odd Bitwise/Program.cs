using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._8_Even_Odd_Bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            if ((number & 1) == 1)
            {
                Console.WriteLine("Number {0} is odd.", number);
            }
            else
            {
                Console.WriteLine("Number {0} is even.", number);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._9_Swap_bitwise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1: ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int numberB = int.Parse(Console.ReadLine());
            numberA = numberA ^ numberB;
            numberB = numberB ^ numberA;
            numberA = numberA ^ numberB;
            Console.WriteLine("NumberA = {0}", numberA);
            Console.WriteLine("NumberB = {0}", numberB);
        }
    }
}

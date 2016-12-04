using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._7_Add_and_Substract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int numberB = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", numberA, numberB, Add(numberA, numberB));
            Console.WriteLine("{0} - {1} = {2}", numberA, numberB, Sub(numberA, numberB));
            Console.ReadLine();
        }
        public static int Add(int numberA, int numberB)
        {
            int helpfulA, helpfulB;
            do
            {              
                helpfulA = numberA & numberB;
                helpfulB = numberA ^ numberB;
                numberA = helpfulA << 1;
                numberB = helpfulB;
            } while (helpfulA != 0);

            return helpfulB;
        }

        public static int Negate(int numberA)
        {
            return Add(~numberA, 1);
        }

        public static int Sub(int numberA, int numberB)
        {
            return Add(numberA, Negate(numberB));
        }
    }
}

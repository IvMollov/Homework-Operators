using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._3_3_bit_and_5_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int numberA = int.Parse(Console.ReadLine());
            int numberB = 40;
            string number = string.Empty;
            if ((numberA & numberB) == 40)
            {
                Console.WriteLine("3 bit and 5 bit of number {0} are 1", numberA);
                Console.WriteLine("Binary number = {0}", number = Convert.ToString(numberA, 2));
            }
            else if ((numberA & numberB) == 32)
            {
                Console.WriteLine("5 bit of number {0} is 1", numberA);
            }
            else if ((numberA & numberB) == 8)
            {
                Console.WriteLine("3 bit of number {0} is 1", numberA);
            }
            else
            {
                Console.WriteLine("3 bit and 5 bit of number {0} are 0", numberA);
            }
        }
    }
}

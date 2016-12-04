using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._13_Flip_bits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            string numberBinary = Convert.ToString(number, 2);
            Console.WriteLine("Binary number before the flip is {0}", numberBinary);
            int x = ~number;
            string flipBinary = Convert.ToString(x, 2);
            Console.WriteLine("Binary number after the flip is {0}", flipBinary);

            Console.ReadLine();
        }
    }
}

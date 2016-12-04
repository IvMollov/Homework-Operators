using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._10_Decimal_toBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            string binaryNumber = GetBinaryNumberBitwise(number);
            Console.WriteLine("Binart number is {0}", binaryNumber);

        }
        public static string GetBinaryNumberBitwise(int number)
        {
            long mask = 2147483648;
            StringBuilder sb = new StringBuilder();
            while(mask > 0)
            {
                if((number & mask) == 0)
                {
                    sb.Append("0");
                }
                else
                {
                    sb.Append("1");
                }
                mask = mask >> 1;
            }
            return sb.ToString();
        }
    }
}

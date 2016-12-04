using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._11_Trailing_zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            TrailingZeros(number);

            Console.ReadLine();
        }
        public static void TrailingZeros(int number)
        {
            int mask = short.MaxValue + 1;
            int count = 0;
            StringBuilder sb = new StringBuilder();
            while (mask > 0)
            {
                if((mask & number) == 0)
                {
                    sb.Append("0");
                }
                else
                {
                    sb.Append("1");
                }
                mask = mask >> 1;
            }

            for (int i = sb.Length - 1; i > 0; i--)
            {
                if (char.GetNumericValue(sb[i]) == 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Trailing zeros of number {0}, binary ({1}) are {2}", number, sb, count);
        }
    }
}

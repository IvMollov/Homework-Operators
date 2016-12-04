using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._14_Number_of_Zeros_and_Ones
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
            int mask = 32768;
            int zeros = 0;
            int ones = 0;
            StringBuilder sb = new StringBuilder();
            while (mask > 0)
            {
                if ((mask & number) == 0)
                {
                    sb.Append("0");
                }
                else
                {
                    sb.Append("1");
                }
                mask = mask >> 1;
            }

            for (int i = 0; i < sb.Length; i++)
            {
                if (char.GetNumericValue(sb[i]) == 0)
                {
                    zeros++;
                }
                else
                {
                    ones++;
                }
            }

            Console.WriteLine("Number {0}, binary ({1}) has {2} zeros and {3} ones", number, sb, zeros, ones);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._6_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter position: ");
            int position = int.Parse(Console.ReadLine());
            int maskZero = 0;
            int maskOne = 1;
            string numberOld = GetBinaryNumberBitwise(number);
            Console.WriteLine("Binary representation of number {0} is {1}", number, numberOld );
            char[] array = new char[numberOld.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = numberOld[i];
            }
            Console.WriteLine();
            
            if ((numberOld[numberOld.Length - (position +1)] & maskOne) == maskOne)
            {
                array[numberOld.Length - (position + 1)] = '0';
            }
            else if (char.GetNumericValue(numberOld[numberOld.Length - (position + 1)]) == maskZero)
            {
                array[numberOld.Length - (position + 1)] = '1';

            }
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);
            }
            sb.ToString();
            string numberNew = sb.ToString();
            int numberA = Convert.ToInt32(numberNew, 2);
            Console.WriteLine("When flip bit on position {0}, old binary number {1},\n become {2} and new decimal number is {3}", position, numberOld, numberNew, numberA);
            Console.ReadLine();


        }
        public static string GetBinaryNumberBitwise(int number)
        {
            long mask = 2147483648;
            StringBuilder sb = new StringBuilder();
            while (mask > 0)
            {
                if ((number & mask) == 0)
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

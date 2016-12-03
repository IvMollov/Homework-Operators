using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._12_Leading_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            string binaryNumber = Convert.ToString(number, 2);
            Console.WriteLine(binaryNumber);
            int bits = sizeof(byte) * 8;
            
            int count = 0;
            for (int i = 1; i < bits; i++)
            {
                if (number < 0)
                {
                    break;
                }
                count++;

                number <<= 0;
                
            }
            Console.WriteLine("Leading zeros are: " + count);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._2_Third_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 3-digits or bigger number: ");
            int number = int.Parse(Console.ReadLine());
            bool isThree = true;
            string newNumber = number.ToString();
            while (int.TryParse(newNumber, out number))
            {
                if (newNumber.Length < 3)
                {
                    Console.Write("Enter 3-digits or bigger number: ");
                    newNumber = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            if ((number / 100) % 10 == 3)
            {
                Console.WriteLine("Is third digit 3? {0}", isThree);
            }
            else
            {
                isThree = false;
                Console.WriteLine("Is third digit 3? {0}", isThree);
            }
            }
        }
}

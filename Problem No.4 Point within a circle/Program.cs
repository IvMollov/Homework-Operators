using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._4_Point_within_a_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter point x: ");
            int pointX = int.Parse(Console.ReadLine());
            Console.Write("Enter point y: ");
            int pointY = int.Parse(Console.ReadLine());
            bool isInside = true;
            if ((pointX * pointX) + (pointY * pointY) <= (5 * 5))
            {
                Console.WriteLine("Is Point({0}, {1}) inside the circle K(0, 5)? {2}", pointX, pointY, isInside);
            }
            else
            {
                isInside = false;
                Console.WriteLine("Is Point({0}, {1}) inside the circle K(0, 5)? {2}", pointX, pointY, isInside);
            }
        }
    }
}

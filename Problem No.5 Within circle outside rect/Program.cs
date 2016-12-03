using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._5_Within_circle_outside_rect
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
            bool outSide = true;
            if (((pointX - 1) * (pointX - 1)) + ((pointY - 1) * (pointY - 1)) <= (3 * 3))
            {
                Console.WriteLine("Is Point({0}, {1}) inside the circle K((1,1),3)? {2}", pointX, pointY, isInside);
            }
            else
            {
                isInside = false;
                Console.WriteLine("Is Point({0}, {1}) inside the circle K((1,1),3)? {2}", pointX, pointY, isInside);
            }
            if ((pointX < 1) && (pointX > 6) && (pointY < -1) && (pointY > 2))
            {
                Console.WriteLine("Is Point({0}, {1}) out of the rectangle R(top=1, left=-1, width=6, height=2)? {2}", pointX, pointY, outSide);
            }
            else
            {
                outSide = false;
                Console.WriteLine("Is Point({0}, {1}) out of the rectangle R(top=1, left=-1, width=6, height=2)? {2}", pointX, pointY, outSide);
            }
            }
        }
}

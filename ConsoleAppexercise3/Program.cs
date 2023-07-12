using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexercise3
{
    internal class Program
    {
        static void Main()

        {
            double length = 5.0;
            double breadth = 3.0;
            double area = 15.0;
            Rectangle rectangle = new Rectangle(length, breadth);
            Console.WriteLine("Area :" + rectangle.CalculateArea());
            Console.WriteLine("Length :" + rectangle.CalculateLength(area , breadth));
            Console.WriteLine("Bradth :" + rectangle.CalculateBreadth(area, length));
            Console.ReadKey();

        }
    }
}





       
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppexercise3
{
    public class Rectangle
    {
        double length;
        double breadth;
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double CalculateArea()
        {
            return length * breadth;

        }
        public double CalculateLength(double area, double breadth)
        {
            return area / breadth;

        }
        public double CalculateBreadth(double length, double area)
        {
            return area / length;
           
        }
    }
}


   
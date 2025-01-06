using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    internal class Rectangle : Shape
    {
        public double length { get; set; }
        public double width { get; set; }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override void area()
        {
            Console.WriteLine("Area: " + length * width);
        }

        public override void perimeter()
        {
            Console.WriteLine("Perimeter: " + 2 * (length + width));
        }
    }
}

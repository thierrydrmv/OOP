using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    internal class Circle : Shape
    {
        public double radius { get; set; }
        public Double pi => Math.Round(Math.PI, 2);
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void area()
        {
            Console.WriteLine("Area: " + Math.Pow(this.radius, 2) * this.pi);
        }

        public override void perimeter()
        {
            Console.WriteLine("Perimeter: " +  2 * this.pi * this.radius);
        }
    }
}

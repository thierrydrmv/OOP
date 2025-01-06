using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Overloading
{
    internal class Calculator
    {
        public void Add(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public void Add(double num1, double num2, double num3)
        {
            Console.WriteLine(num1 + num2 + num3);
        }
        //var calculator = new Calculator();
        //calculator.Add(1, 2);
        //calculator.Add(1, 2, 12);
    }
}

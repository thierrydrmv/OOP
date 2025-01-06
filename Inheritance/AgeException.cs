using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class AgeException : Exception
    {
        public AgeException()
        { }
        public AgeException(int age) : base($"Invalid age: {age} (< 0 or > 120)")
        { }
    }
}

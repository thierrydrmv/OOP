using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    internal class Bird : Animal
    {
        public override void animal_move()
        {
            Console.WriteLine("Fly");
        }
    }
}

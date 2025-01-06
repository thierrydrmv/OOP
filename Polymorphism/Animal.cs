using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    internal class Animal
    {
        public virtual void animal_move()
        {
            Console.WriteLine("Move");
        }
        public static void move(Animal Object)
        {
            Object.animal_move();
        }
        // testing
        //var gralhaAzul = new Bird();
        //var basset = new Dog();
        //var salmao = new Fish();
        //Animal.move(gralhaAzul);
        //Animal.move(basset);
        //Animal.move(salmao);
        //new Animal().animal_move();
    }
}

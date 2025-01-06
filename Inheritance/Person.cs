using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public Person() 
        {
            // testing with constructor
            try
            {
                var student = new Student("Thierry", 26, "1");
                var person = new Person("Jonas", 22);
                ValidateAge(student);
                ValidateAge(person);
                student.introduce();
                Console.WriteLine("----------");
                person.introduce();
            }
            catch (AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void introduce()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}");
        }
        public static void ValidateAge(Person person)
        {
            if (person.age < 0 || person.age > 120)
                throw new AgeException(person.age);
        }
    }
}

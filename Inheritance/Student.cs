using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class Student : Person
    {
        public string student_id { get; set; }
        public Student(string name, int age, string student_id) : base(name, age)
        {
            this.student_id = student_id;
        }
        
        public override void introduce()
        {
            Console.WriteLine($"Name: {name}\nAge: {age}\nId: {student_id}");
        }
    }
}

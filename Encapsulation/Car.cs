using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        private int year { get; set; }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public Car()
        {
            // testing with constructor
            var car1 = new Car("Toyota", "runn", 2000);
            var car2 = new Car("Mustang", "gt", 2022);
            car1.display_info();
            car2.display_info();
            // setter
            car1.Year = 2201;
            // getter
            Console.WriteLine(car1.Year);
        }
        public Car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }
        public void display_info()
        {
            Console.WriteLine($"The car has a brand: {brand}," +
                $" the model {model} and is from {year}.");
        }
    }
}

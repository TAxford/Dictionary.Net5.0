using System;
using System.Collections.Generic;

namespace Dictionary.Net5._0
{
    internal class Program
    {

        // Key - Value
        // Auto - Car

        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }
            };





            Console.WriteLine("Hello World!");
        }
    }

    class Employee
    {
        //few properties like Role Name, Ahe and Rate

        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        //Yearly Salary = rate/h * number of days * number of weeks * number of months

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        //simple constructor
        public Employee(string role, string name, int age)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = Rate;
        }
    }

}

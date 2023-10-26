using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
                new Customer
                {
                    FirstName = "Nisa"
                }, 
                new Student
                {
                    FirstName = "Kübra"
                }, 
                new Person
                {
                    FirstName = "Melike" 
                }
            };

            foreach (var persons in person)
            {
                Console.WriteLine(persons.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int MyProperty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }


    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}

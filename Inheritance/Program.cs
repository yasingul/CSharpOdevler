using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance   //Türkçesi kalıtım veya miras olarak düşünülebilir.
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person
                {
                    FirstName="Ece" 
                }, 
                new Customer
                {
                    FirstName="Yasin"
                }, 
                new Student
                {
                    FirstName="Said"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    class Person       
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person   //Bir kişinin bir tane Inheritance'ı olabilir ama interfacelerde böyle bir sınırlama olmamaktadır.
    {
        public string City { get; set; }
    }
    class Student: Person
    {
        public string Department { get; set; }
    }
}

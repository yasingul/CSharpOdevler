using System;

namespace Constructors
{
    //Constructor bir class'ı new'lediğimiz zaman oluşan bloktur.
    //parametresi olmaya contructor'a default constructor denir.
    //constructorlar method'lar gibi kullanılabilir.
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer () {Id=1, FirstName="Yasin", LastName="GÜL", City="Antalya" };    //new işlemi yapılır yapılmaz constructor çalışır. Burada default constructor çalıştırmış olduk.
            
            Customer customer2 = new Customer (2, "Ece", "Küçükşahin", "İstanbul");     //üsttekiyle aynı şeyi yaptık aslında. Burada ise kendi olşturduğumuz constructor'u oluşturmuş olduk.

            Customer customer3 = new Customer();    //10. satırda ki kullanımla aynı kullanım.
            customer3.Id = 3; 
            customer3.FirstName = "Sait";
            customer3.LastName = "Gül";
            customer3.City = "İstabul";

            Console.WriteLine(customer2.FirstName);
        }

    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)   //ctor ile constructor oluşturuyoruz. Eğer bu bloğu kendimiz yazarsak default olarak gelen constructor'ı ezmiş oluruz.
        {
            Id = Id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            //14. kod bloğunda ki değerleri okuması için değerleri constructor'a tanımlarız.
            Console.WriteLine("Yapıcı blok çalıştı.");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

using System;

namespace ReferenceTypes
{
    class Program   //4. Gün 1. Ödev videosu.
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean; value types (sayısal veriler değer tiplerdir.)
            //hafızada STACK'de işlem görür ve orada depolanır.
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;  //"sayi1'in değeri = sayi2'nin değeri" diye okunur.
            sayi2 = 100;

            Console.WriteLine("sayi1 :" + sayi1);

            //array, class,interface reference types(referans tipler)
            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;    //"sayilar1'in adresi = sayilar2'nin adresi" diye okunur.
            sayilar2[0] = 1000;

            Console.WriteLine("sayilar1[0] = " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";
            
            person2 = person1;  //Burada adres eşitlemesi yaptık, değer eşitlemesi yapılmaz.
            person1.FirstName = "Derin";

            Console.WriteLine(person2.FirstName);

            Customer customer1 = new Customer();
            customer1.FirstName = "Salih";
            customer1.CreditCardNumber = "12345678910";
            Employee employee = new Employee();

            Person person3 = customer1;
            customer1.FirstName = "Ahmet";
            Console.WriteLine("person3.FirstName");
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            //person3 değerinden CreditCardNumber'a ulaşmak için kutulama yaptık. Aynı işlemi Employee içinde yapabiliriz.

            PersonManager personManager = new PersonManager();
            personManager.Add(customer1);
            //Person yerine Customer gönderebilmemizin sebebi parametre olarak base class'ı kullanmamız.
        }
    }
    
    class Person    //Base Class - Temel Sınıf. Customer ve Employee'nin adreslerini tutabiliyor.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
    class Customer:Person   //Customer'ın içimde Person classına ek olarak Kredi Kartı numarası var demek.
    {
        public string CreditCardNumber { get; set; }
    }
            
    class Employee: Person   //Employee'nin içimde Person classına ek olarak EmployeeNumber var demek.
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) //Parametrem base temel olan person olduğu için Add fonksiyonunu rahatça Employee ve Customer için kullanabilirim.
        {
            Console.WriteLine(person.FirstName + " Eklendi.");
        }
    }
}

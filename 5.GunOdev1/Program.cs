using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //38. Video Notları:
            //Classların en temel tanımı: Yapmak istediğimiz işlemleri gruplara ayırmak, o grup üzerinden işlemlerimizi yapmak ve rahatlıkla bu gruba ulaşmak için kullanabiliriz.
            CustomerManager customerManager = new CustomerManager();  //class'ın örnerğini oluşturduk.
            customerManager.Add();
            customerManager.Update();
            
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id= 1;
            customer1.FirstName = "Ali";
            customer1.LastName = "Şen";
            customer1.City = "Antalya";

            Customer customer2 = new Customer
            {   //ctrl+space tuşları ile propları getirebiliyoruz.
               Id=2, FirstName="Yasin", LastName="Gül", City="İstanbul"
            };

            Console.WriteLine(customer2.FirstName);     //Burada çalışan blok "get" bloğudur.
        }
    }

}

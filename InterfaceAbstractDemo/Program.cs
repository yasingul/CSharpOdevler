using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    //Demoda Starbucks ve Nero firmaları için çalışıyoruz. Müşterileri veri tabanına kaydedeceğiz.
    //Starbucks mernis doğrulama isterken Nero istemiyor ayrıca Starbucks her kahve alımında yıldız kazandırmak istiyor.
    class Program
    {
        static void Main(string[] args)
        {
            //StarBucks ile çalışıyorsak DateTime, FirstName, LastName ve NationalityId'nin doğru olması lazım
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer { DateOfBirth = new DateTime(1994, 7, 25), FirstName = "Yasin", LastName = "Gül", NationalityId = "12345678910" });  

            Console.ReadLine();
        }
    }

}

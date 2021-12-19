using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //Dal data access layer'dan gelir. Veri işlerini yapmak için kullanacağımız sınıftır. Insert, Update, Delete gibi veritabanı işlerini burada yaparız.
    //Gerçek uygulamalarda interface'i burada farklı implementasyonlar için kullanırız.
    //Farklı implementasyonlar örneğin SQL server veya Oracle destekli ve ya DB2, MySQL destekli bir sistem yazmak istiyoruz.
    //Her biri için kullanılan teknoloji farklı olduğu için her biri için farklı şekilde düzenlememiz gerekmektedir.
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }
    class MySqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("MySql Updated");
        }
    }
    class CustomerManager   
    {
        public void Add(ICustomerDal customerDal)      //Bu yöntem ile programın bağımlılığını en aza indirgemiş olduk.
        {
            customerDal.Add();
        }
    }
}

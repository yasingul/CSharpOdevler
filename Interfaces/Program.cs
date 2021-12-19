using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();

            //Bu örnekte şirketimize ait veriyi hem SQL'e hem de Oracle'a yazmamız gerekiyor. Bunun için:
            ICustomerDal[] customerDals = new ICustomerDal[3] 
            {   //Veri tabanına eklenen yeni bir eklentiyi sorunsuz bir şekilde sistemimize eklemiş olduk.
                new SqlServerCustomerDal(), 
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            
            
            
            
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());    //sql ile uyumlu
            customerManager.Add(new OracleCustomerDal());       //Oracle ile uyumlu
        }

        private static void InterfacesIntro() 
        {
            PersonManager manager = new PersonManager();
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Yasin",
                LastName = "Gül",
                Adress = "Antalya"
            };
            manager.Add(new Student { Id = 1, FirstName = "Yasin", LastName = "Gül", Department = "Computer" });
            manager.Add(customer1);

        }
    }
    //class olan Customer ve Student somut nesnelerdir, interface olan IPerson ise soyut nesnedir.
    interface IPerson
    {
        //Interface ve abstrac gibi bu tip soyut nesneleri new'lememiz mümkün değildir.
        int Id { get; set; }    //Interfaceler yazılırken tamamen metodun imzası ve özelliği yazılır.
        string  FirstName { get; set; }     
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

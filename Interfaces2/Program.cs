using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
        //Video izlerken aldığım notlar.
        //Interface'lerde metodun içerisi doldurulmaz. Classlarda miras ile başka koda implemente ettiğimiz kod aynı demekken burada sadece metod aynıdır. Kodun içeriğini class'ın özelliğine göre değiştirebiliriz.
        //Class'larda bu işleme "inherits" deniliyor.
        //Interface'lerde ise "implements" deriz.
        //Interface'ler new'lenemez
        //Interface'lerde implemente edilen kodlarda interface'e ait tüm metodları içermek zorundadır.
        //Interface'ler referans tiptir o yüzden implemente oldukları classların referans değerlerini tutabiliyor.
        //Interface'ler yapılan değişiklikleri kodları bozmadan eklememizi de sağlar.
    class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();

            //IPersonManager employeeManager = new EmployeeManager();     

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

            Console.ReadLine();
        }
    }
    class PersonManager
    {
        //Implemented operation
        public void Add()
        {
            Console.WriteLine("Eklendi");
        }
    }
    interface IPersonManager
    {
        //Unimplemented operation
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ile ilgili kodları yazarız.
            Console.WriteLine("Müşteri eklendi!");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi!");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Personel ile alakalı kodlar burada yazılır.
            Console.WriteLine("Personel eklendi!");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi!");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi!");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi!");
        }
    }

    class ProjectManager        //Bütün projeyi tek bir kod ile yönettiğimiz bir sistemdir.
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}

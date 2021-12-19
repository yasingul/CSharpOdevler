using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Burada yaptığımız işlem Interface'lerin doğru planlanmasıdır. SOLID'in 4. harfidir. Interface Segregation.
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

        }
    }
    //Bir şirkette çalışan çeşitli çalışanlar olduğunu düşünelim.

    interface IWorker      //çalışanlarla alakalı şartlar.
    {
        void Work();
    }
    interface IEat      //Yemekle alakalı şartlar.
    {
        void Eat();
    }
    interface ISalary       //Maaşla alakalı şartlar.
    {
        void GetSalary();
    }

    //Bir class birden fazla interface'i implemente edebilir.
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker   //robot Eat ve Salary kısmında sorun olacağı için kullanmamız gerekiyor.
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}

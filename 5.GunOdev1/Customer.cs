using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //property: class'ın özelliklerini tanımlarız.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        //private string _firstName;      //buna field deniyor.
        //public string FirstName     //Bir field üzerinde get veya set ederken yani değeri verirken veya değeri okurken. Başka bir şey yapmak istersek izlememiz gereken yol budur.
        //{                           //Bu yapılan tekniğe encapsulation denir.
        //    get { return "Mr." + _firstName; }
        //    set { _firstName = value; }
        //}
    }
}

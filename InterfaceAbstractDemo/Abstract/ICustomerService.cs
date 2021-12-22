using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);   //iki firmada bizden kayıt yapmamızı istiyor. Bu yaı bütün müşterilerde olacak.

    }
}

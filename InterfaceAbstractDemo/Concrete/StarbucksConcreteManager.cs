using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksConcreteManager: BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksConcreteManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)    //Burada kişinin doğru olup olmadığını kontrol ediyoruz.
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            } else
            {
                throw new Exception("Not a valid person");
            }
        }

    }
}

using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db : " + customer.FirstName + " " + customer.LastName + " " + customer.DateOfBirth.Year);
        }
    }
}

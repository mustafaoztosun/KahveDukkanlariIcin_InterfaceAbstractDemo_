using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}

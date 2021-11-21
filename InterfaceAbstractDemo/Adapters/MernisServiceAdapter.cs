using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using MernisServiceReference;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(customer.NationaityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1995,10,10), FirstName
             = "Mustafa", LastName = "Öztosun", NationaityId = "42424753988"});

            Console.ReadLine();
        }
    }
}

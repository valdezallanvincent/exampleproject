using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Providers.IRepository
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomersList();
        Customer GetCustomer(long Id);
        long CreateCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(long Id);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Providers.IRepository;
using Entities.Models;
using System.Linq;
namespace DataAccess.Providers.Repository
{
  
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomersList()
        {
            var staticCustomer = StaticCustomer.Customers;
            return staticCustomer;
        }
        public Customer GetCustomer(long Id)
        {
            var customer = StaticCustomer.Customers.Where(x => x.Id==Id).FirstOrDefault();
            return customer;
        }
        public long CreateCustomer(Customer customer)
        {
            long id = StaticCustomer.Customers.Max(i => i.Id);
            customer.Id = id+1;
            StaticCustomer.Customers.Add(customer);  
            return customer.Id;
        }
        public bool UpdateCustomer(Customer customer)
        {
            int index = StaticCustomer.Customers.FindIndex(i=>i.Id == customer.Id);
            if (index >= 0)
            {
                StaticCustomer.Customers[index] = customer;
                return true;
            }
            return false;
        }
        public bool DeleteCustomer(long Id)
        {
            int index = StaticCustomer.Customers.FindIndex(i => i.Id == Id);
            if (index >= 0)
            {
                StaticCustomer.Customers.RemoveAt(index); 
                return true;
            }
            return false;
        }
    }
}

using BusinessLogicService.IBusinessLogicService;
using DataAccess.Providers.IRepository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace BusinessLogicService.BusinessLogicService
{
    public class CustomerBLS : ICustomerBLS
    {
        private ICustomerRepository customerRepository;
        public CustomerBLS(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        public List<Customer> GetCustomersList()
        {
            var returnData = customerRepository.GetCustomersList();
            return returnData;
        }
        public Customer GetCustomer(long Id)
        {
            var returnData = customerRepository.GetCustomer(Id);
            return returnData;
        }
        public long CreateCustomer(Customer customer)
        {
            var Id = customerRepository.CreateCustomer(customer);
            return Id;
        }
        public bool UpdateCustomer(Customer customer)
        {
            var result = customerRepository.UpdateCustomer(customer);
            return result;
        }
        public bool DeleteCustomer(long Id)
        {
            var result = customerRepository.DeleteCustomer(Id);
            return result;
        }
    }
}

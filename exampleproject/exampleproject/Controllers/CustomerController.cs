using BusinessLogicService.IBusinessLogicService;
using Entities.Models;
using exampleproject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace exampleproject.Controllers
{
    public class CustomerController : ApiController
    {
        ICustomerBLS customerBLS;
        public CustomerController(ICustomerBLS customerBLS)
        {
            this.customerBLS = customerBLS;
        }
        [HttpGet]
        [AuthorizeCoreHelper]
        public IHttpActionResult GetCustomersList()
        {
            
            var returnData = customerBLS.GetCustomersList();
            return Ok(returnData);
           
        }
        [HttpGet]
        [AuthorizeCoreHelper]
        public IHttpActionResult GetCustomer(long Id)
        {
         
                var returnData = customerBLS.GetCustomer(Id);
                return Ok(returnData);
     
        }
        [HttpPost]
        [AuthorizeCoreHelper]
        public IHttpActionResult CreateCustomer([FromBody] Customer customer)
        {
             
                var Id = customerBLS.CreateCustomer(customer);
                return Ok(Id);
            
           
        }
        [HttpPut]
        [AuthorizeCoreHelper]
        public IHttpActionResult UpdateCustomer([FromBody] Customer customer)
        {
            
                var result = customerBLS.UpdateCustomer(customer);
                if (result)
                {
                    return Ok(result);
                }
                return NotFound();
          
           
        }
        [HttpDelete]
        [AuthorizeCoreHelper]
        public IHttpActionResult DeleteCustomer(long Id)
        {
           
                var result = customerBLS.DeleteCustomer(Id);
                if (result)
                {
                    return Ok(result);
                }
                return NotFound();
            
        }
        [HttpGet]
        public IHttpActionResult ExampleErrorLog()
        {

            int test = int.Parse("S");
            return Ok();
      

        }


    }
}

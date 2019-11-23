using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public DateTime? DOB { get; set; }
        public long? Age { get; set; }
        public List<Address> AddressList { get; set; }
        public Customer()
        {
            Id = 0;
            FullName = "";
            DOB = null;
            Age = null;
            AddressList = new List<Address>();
        }
    }

    public static class StaticCustomer
    {
        public static List<Customer> Customers = new List<Customer>()
        {
            new Customer
            { 
                Id=1, FullName="Allan Valdez", DOB= new DateTime(1996,04,01),Age=23,AddressList=new List<Address>(){ new Address { Addressline1="Batimana",Addressline2= "Marulas", City="Valenzuela",State="Philippines"} }
            },
            new Customer
            {
                Id=2, FullName="FirstNameTest LastNameTest", DOB= new DateTime(2006,04,01),Age=49,AddressList=new List<Address>(){ new Address { Addressline1="BatimanaTest",Addressline2= "MarulasTest", City="ValenzuelaTest",State="PhilippinesTest"} }
            }
        };
    }
}

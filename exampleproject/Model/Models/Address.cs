using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Address
    {
        public string Addressline1 { get; set; }
        public string Addressline2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Address()
        {
            Addressline1 = "";
            Addressline2 = "";
            City = "";
            State = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{
    public class Address
    {
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string ZipCode { get; set; }
        public int StreetNumber { get; set; }

        public Address(int streetNumber, string streetName, string city, string province, string zipCode)
        {
            StreetName = streetName;
            City = city;
            Province = province;
            ZipCode = zipCode;
            StreetNumber = streetNumber;
        }
    }
}

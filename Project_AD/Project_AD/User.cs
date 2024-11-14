using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{
    public abstract class User
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }

        public User(string fname, string lname, Address address, string phoneNumber)
        {
            FName = fname;
            LName = lname;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{
    public class Employee : User
    {
        private static int employeeIdCounter = 1;
        public string EmployeeId { get; private set; }

        public Employee(string fName, string lName, Address address, string phoneNumber)
            : base(fName, lName, address, phoneNumber)
        {
            EmployeeId = employeeIdCounter++.ToString(); // Auto-increment employee ID (as string)
        }
    }
}

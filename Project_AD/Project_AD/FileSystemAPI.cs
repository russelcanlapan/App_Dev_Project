using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{
    public static class FileSystemAPI
    {
        private static string memberFilePath = "members.txt";
        private static string employeeFilePath = "employees.txt";

        private static List<Employee> employees = new List<Employee>
        {
            new Employee("John", "Doe", new Address(123, "Main St", "Montreal", "QC", "H2X 1X1"), "514-123-4567"),
            new Employee("Jane", "Smith", new Address(456, "Baker St", "Quebec City", "QC", "G1K 2N3"), "418-987-6543"),
            new Employee("Alice", "Johnson", new Address(789, "Elm St", "Ottawa", "ON", "K1A 0B1"), "613-555-7890"),
            new Employee("Bob", "White", new Address(101, "Maple Ave", "Toronto", "ON", "M5H 2N2"), "416-555-1234")
        };

        public static Employee GetEmployeeById(int employeeId)
        {
            // Find the employee where the EmployeeId matches the given employeeId
            return employees.FirstOrDefault(e =>
            {
                // Try to parse the EmployeeId and compare it with employeeId
                return int.TryParse(e.EmployeeId, out int parsedEmployeeId) && parsedEmployeeId == employeeId;
            });
        }

        public static void LoadEmployeesFromFile()
        {
            // For demonstration purposes, let's load from a file (we're not using this in this scenario)
            if (File.Exists("employees.txt"))
            {
                var lines = File.ReadAllLines("employees.txt");

                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    Address address = new Address(int.Parse(data[2]), data[3], data[4], data[5], data[6]);
                    Employee employee = new Employee(data[0], data[1], address, data[7]);
                    employees.Add(employee);
                }
            }
        }

        public static void SaveMember(int memberID, string firstName, string lastName, string phoneNumber,
                                       int streetNumber, string streetName, string city, string province,
                                       string zipCode, string membershipType, double balance)
        {
            int newMemberId = 1;

            // Check if the file exists
            if (File.Exists(memberFilePath))
            {
                // Read all lines and find the highest MemberId
                var lines = File.ReadAllLines(memberFilePath);

                if (lines.Length > 0)
                {
                    newMemberId = lines
                        .Select(line => int.Parse(line.Split(',')[0])) // Extract MemberId from each line
                        .Max() + 1; // Increment the highest MemberId
                }
            }

            // Append the new member's data to the file
            using (StreamWriter writer = new StreamWriter(memberFilePath, true))
            {
                writer.WriteLine($"{newMemberId},{firstName},{lastName},{phoneNumber}," +
                                 $"{streetNumber},{streetName},{city},{province}," +
                                 $"{zipCode},{membershipType},{balance:F2}");
            }
        }

        public static string GetMemberById(int memberId)
        {
            if (!File.Exists(memberFilePath))
            {
                return null; // File not found
            }

            using (StreamReader reader = new StreamReader(memberFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] memberData = line.Split(',');
                    if (int.Parse(memberData[0]) == memberId)
                    {
                        return line; // Return the matching member's data as a single string
                    }
                }
            }
            return null; // Member not found
        }
    }
}

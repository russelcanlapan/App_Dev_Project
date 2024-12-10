using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

        /*
 * This method retrieves an Employee object by matching the EmployeeId with the given employeeId.
 * It searches through the list of employees and returns the first match found.
 * param: employeeId - The ID of the employee to be retrieved.
 * return: Employee - The Employee object if found, or null if not found.
 */
        public static Employee GetEmployeeById(int employeeId)
        {
            // Find the employee where the EmployeeId matches the given employeeId
            return employees.FirstOrDefault(e =>
            {
                // Try to parse the EmployeeId and compare it with employeeId
                return int.TryParse(e.EmployeeId, out int parsedEmployeeId) && parsedEmployeeId == employeeId;
            });
        }
        
/*
* This method loads the list of employees from a file (employees.txt) and adds them to the employees list.
 * It splits each line of the file by commas and creates an Employee object for each line.
 * return: N/A
 */
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
        /*
 * This method saves a new member to a file. It checks if the file exists and retrieves the highest member ID, 
 * then increments it for the new member. The member's data is then appended to the file.
 * param: memberID 
 * param: firstName 
 * param: lastName 
 * param: phoneNumber 
 * param: streetNumber
 * param: streetName 
 * param: city 
 * param: province 
 * param: zipCode 
 * param: membershipType 
 * param: balance 
 * return: N/A
 */
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


        /*
 * This method removes a member from the file by finding the member's data using their ID and rewriting the file without the member.
 * It creates a temporary file, copies over all lines except the member to be removed, and then replaces the original file.
 * param: memberId - The ID of the member to be removed.
 * return: N/A
 */
        public static void RemoveMember(int memberId)   
        {
            string memberToRemove = GetMemberById(memberId);
            if (memberToRemove == null)
            {
                MessageBox.Show("Member Not Found.");
            }
            else
            {
                string tempFilePath = "tempFile.txt";
                using (StreamReader reader = new StreamReader(memberFilePath))
                using (StreamWriter writer = new StreamWriter(tempFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line != memberToRemove)
                        {
                            writer.WriteLine(line);
                        }
                    }
                }   
                File.Delete(memberFilePath);
                File.Move(tempFilePath, memberFilePath);

                MessageBox.Show("Member removed.");
            }
        }

        /*
 * This method retrieves a member's data by their ID from the file. It reads the file and looks for a match on the Member ID.
 * param: memberId - The ID of the member to retrieve.
 * return: string - The member's data as a string if found, or null if not found.
 */


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
        /*
 * This method updates an existing member's data by finding the member in the file and writing the updated data to a temporary file.
 * The original file is then replaced with the updated file.
 * param: memberId, firstName, lastName, phoneNumber, streetNumber, streetName, city, province, zipCode, membershipType, balance
 * return: N/A
 */
        public static void UpdateMember(int memberId, string firstName, string lastName, string phoneNumber,
                                int streetNumber, string streetName, string city, string province,
                                string zipCode, string membershipType, double balance)
        {
            string memberToUpdate = GetMemberById(memberId);
            if (memberToUpdate == null)
            {
                MessageBox.Show("Member Not Found.");
            }
            else
            {
                string tempFilePath = "tempFile.txt";
                using (StreamReader reader = new StreamReader(memberFilePath))
                using (StreamWriter writer = new StreamWriter(tempFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] memberData = line.Split(',');
                        if (int.Parse(memberData[0]) == memberId)
                        {
                            // Update member data
                            writer.WriteLine($"{memberId},{firstName},{lastName},{phoneNumber}," +
                                             $"{streetNumber},{streetName},{city},{province}," +
                                             $"{zipCode},{membershipType},{balance:F2}");
                        }
                        else
                        {
                            writer.WriteLine(line); // Write other members unchanged
                        }
                    }
                }
                File.Delete(memberFilePath);
                File.Move(tempFilePath, memberFilePath);

                MessageBox.Show("Member updated successfully.");
            }
        }
    }
}

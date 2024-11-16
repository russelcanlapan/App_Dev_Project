using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_AD
{
    public static class FileSystemAPI
    {
        private static string filePath = "members.txt";

        public static void SaveMember(int memberID, string firstName, string lastName, string phoneNumber,
                                       int streetNumber, string streetName, string city, string province,
                                       string zipCode, string membershipType, double balance)
        {
            int newMemberId = 1;

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines and find the highest MemberId
                var lines = File.ReadAllLines(filePath);

                if (lines.Length > 0)
                {
                    newMemberId = lines
                        .Select(line => int.Parse(line.Split(',')[0])) // Extract MemberId from each line
                        .Max() + 1; // Increment the highest MemberId
                }
            }

            // Append the new member's data to the file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{newMemberId},{firstName},{lastName},{phoneNumber}," +
                                 $"{streetNumber},{streetName},{city},{province}," +
                                 $"{zipCode},{membershipType},{balance:F2}");
            }
        }

        public static string GetMemberById(int memberId)
        {
            if (!File.Exists(filePath))
            {
                return null; // File not found
            }

            using (StreamReader reader = new StreamReader(filePath))
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

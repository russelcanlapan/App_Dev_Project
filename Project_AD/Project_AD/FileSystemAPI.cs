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

        public static void SaveMember(int memberId, string firstName, string lastName, string phoneNumber,
                                       int streetNumber, string streetName, string city, string province,
                                       string zipCode, string membershipType, double balance)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{memberId},{firstName},{lastName},{phoneNumber}," +
                                 $"{streetNumber},{streetName},{city},{province}," +
                                 $"{zipCode},{membershipType},{balance}");
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
                        return line; // Return the matching member's data
                    }
                }
            }
            return null; // Member not found
        }
    }
}

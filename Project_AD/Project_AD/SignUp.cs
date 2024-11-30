using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_AD
{
    public partial class SignUp : Form
    {
        public static bool IsOpenedFromEmployeeLogin = false;

        public SignUp()
        {
            InitializeComponent();
            UpdateComponent();

            regularRB.Checked = true;
            monthlyRB.Checked = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MembershipType membershipType = MembershipType.Regular; // Default to Regular
            Membership membership = new Membership(membershipType);

            // Determine membership type and frequency
            membershipType = regularRB.Checked ? MembershipType.Regular : MembershipType.Premium;
            string frequencyType = monthlyRB.Checked ? "Monthly" : "Yearly";

            // Create a new Member instance
            Member newUser = new Member(
                firstNameTB.Text,
                lastNameTB.Text,
                phoneNumberTB.Text,
                new Address(
                    int.Parse(streetNumberTB.Text),
                    streetNameTB.Text,
                    cityTB.Text,
                    provinceTB.Text,
                    zipcodeTB.Text
                ),
                membership,
                membership.GetPrice(frequencyType)
            );

            // Save the member information to the file (MemberId will be auto-generated)
            FileSystemAPI.SaveMember(
                int.Parse(newUser.MemberId),
                newUser.FName,
                newUser.LName,
                newUser.PhoneNumber,
                newUser.Address.StreetNumber,
                newUser.Address.StreetName,
                newUser.Address.City,
                newUser.Address.Province,
                newUser.Address.ZipCode,
                membershipType.ToString(),
                newUser.Balance
            );

            // Display confirmation or handle the user object as needed
            MessageBox.Show("User information saved successfully.\n Member ID: " + newUser.MemberId);
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Hide the current form (SignUp)
            this.Hide();

            if (SignUp.IsOpenedFromEmployeeLogin)
            {
                // If opened from Employee Login, go back to Employee Login
                if (EmployeeLogin.ActiveForm != null)
                {
                    Application.OpenForms["EmployeeLogin"].Show();
                }
            }
            else
            {
                // If opened from Form1, go back to Form1
                if (Form1.ActiveForm != null)
                {
                    Application.OpenForms["Form1"].Show();
                }
            }

            // Close the current form
            this.Close();
        }
    }
}

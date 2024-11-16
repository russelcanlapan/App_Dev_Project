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
    public partial class UpdateProfile : Form
    {

        public UpdateProfile()
        {
            InitializeComponent();

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
                MembershipType membershipType = new MembershipType();
                Membership membership = new Membership(membershipType);
                string frequencyType = "";

                if (regularRB.Checked)
                {
                    if (monthlyRB.Checked)
                    {
                        frequencyType = "monthly";
                    }
                    else if (yearlyRB.Checked)
                    {
                        frequencyType = "yearly";
                    }
                }
                else if (premiumRB.Checked)
                {
                    membershipType = MembershipType.Premium;
                    if (monthlyRB.Checked)
                    {
                        frequencyType = "monthly";
                    }
                    else if (yearlyRB.Checked)
                    {
                        frequencyType = "yearly";
                    }
                }
                // Create a new User instance
                Member updatedMember = new Member(firstNameTB.Text, lastNameTB.Text, 
                    phoneNumberTB.Text, new Address(int.Parse(streetNumberTB.Text), streetNameTB.Text,
                    cityTB.Text, provinceTB.Text, zipcodeTB.Text), membership, membership.GetPrice(frequencyType));

                // Save the member information to the file
                FileSystemAPI.SaveMember(
                    int.Parse(updatedMember.MemberId), updatedMember.FName, updatedMember.LName, updatedMember.PhoneNumber,
                    updatedMember.Address.StreetNumber, updatedMember.Address.StreetName, updatedMember.Address.City,
                    updatedMember.Address.Province, updatedMember.Address.ZipCode, membershipType.ToString(),
                    updatedMember.Balance);

                // Display confirmation or handle the user object as needed
                MessageBox.Show("User information saved successfully.\nMember ID: " + updatedMember.MemberId);
            }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Hide the current form (ViewProfile)
            this.Hide();

            // Show the main form (Form1)
            Application.OpenForms["MemberLogin"].Show();

            // Close the current form
            this.Close();
        }
    }
}
